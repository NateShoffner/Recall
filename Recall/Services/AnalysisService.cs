using System.Diagnostics;
using OpenAI.Chat;
using Recall.Models;
using SQLite;

namespace Recall
{

    internal class AnalysisService
    {
        string apiKey = "";
        string model = "gpt-4o";

        ChatClient _client;
        private SQLiteConnection _db;


        public AnalysisService(SQLiteConnection db)
        {
            _db = db;
            _client = new(model, apiKey);
        }

        public Analysis AnaylizeScreenshot(Screenshot screenshot)
        {
            using Stream imageStream = File.OpenRead(screenshot.Path);
            BinaryData imageBytes = BinaryData.FromStream(imageStream);

            const string prompt = "Please describe the following screenshot. Please refrain from disclosing any personal or sensitive information.";

            List<ChatMessage> messages = new()
            {
                new UserChatMessage(
                    ChatMessageContentPart.CreateTextMessageContentPart(prompt),
                    ChatMessageContentPart.CreateImageMessageContentPart(imageBytes, "image/png"))
            };

            ChatCompletion chatCompletion = _client.CompleteChat(messages);

            string response = chatCompletion.Content[0].ToString();

            //Debug.WriteLine(chatCompletion);

            Analysis analysis = new Analysis
           {
                Model = model,
                Prompt = prompt,
                Created = DateTime.Now,
                Response = response,
                ScreenshotId = screenshot.Id
            };

            _db.Insert(analysis);
            return analysis;
        }
    }
}
