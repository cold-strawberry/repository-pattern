using System;
using Newtonsoft.Json;
using Premium.Commons.Messages;
using Premium.Commons.Types;

namespace Premium.ProcessManager.Messages.Commands
{
    public class UserCommand : ICommand
    {
        public string Action { get;  set; }
        public string Application { get;  set; }
        public string Market { get;  set; }

        public string User { get;  set; }

        public DateTime? OperatedAtTime { get;  set; }

        private UserCommand() {}

        [JsonConstructor]
        public UserCommand(string action, string application, string market, string user)
        {
            if (string.IsNullOrWhiteSpace(action))
            {
                throw new PremiumException("Invalid action", "null action");
            }
            if (string.IsNullOrWhiteSpace(application))
            {
                throw new PremiumException("Invalid application", "null application");
            }
            if (string.IsNullOrWhiteSpace(market))
            {
                throw new PremiumException("Invalid market", "null market");
            }
            if (string.IsNullOrWhiteSpace(user))
            {
                throw new PremiumException("Invalid user", "null user");
            }
            Action = action;
            Application = application;
            Market = market;
            OperatedAtTime = DateTime.UtcNow;
            User = user;
        }
    }
}
