class Notification
    {
        private string Message { get; set; }

        public Notification(string message)
        {
            Message = message;
        }

        public void Send()
        {
            Console.WriteLine($"Notification: {Message}");
        }
    }