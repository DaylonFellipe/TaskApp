﻿namespace Daylon.TaskApp.Communication.Responses
{
    public class ResponseUpdateTaskJson
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
