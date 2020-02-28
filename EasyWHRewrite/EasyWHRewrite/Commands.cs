using System;

namespace EasyWHRewrite
{
    class Commands
    {
        private WebhookHandler WH;
        public Commands() { }

        public void SetWH(WebhookHandler WH)
        {
            this.WH = WH;
        }

        // Call a command and return the output of it
        // Errors should start with `err: ` and provide a usage message
        public string Call(string Command, string[] Args)
        {
            switch (Command)
            {
                case "name":
                    if(Args.Length < 1)
                    {
                        return "err: Not enough parameters\nUsage: /name <name>";
                    } 
                    else
                    {
                        WH.Nick = string.Join(" ", Args);
                        return "Your name has been changed to `" + WH.Nick + "`.";
                    }
                case "avatar":
                    if (Args.Length < 1)
                    {
                        return "err: Not enough parameters\nUsage: /avatar <url>";
                    }
                    else
                    {
                        WH.Avatar = string.Join(" ", Args);
                        return "Your name has been changed to `" + WH.Avatar + "`.";
                    }
                case "me":
                    if (Args.Length < 1)
                    {
                        return "err: Not enough parameters\nUsage: /me <action>";
                    }
                    else
                    {
                        return WH.Talk("*"+string.Join(" ", Args)+"*");
                    }
                case "bold":
                    if (Args.Length < 1)
                    {
                        return "err: Not enough parameters\nUsage: /bold <text>";
                    }
                    else
                    {
                        return WH.Talk("**" + string.Join(" ", Args) + "**");
                    }
                case "code":
                    if (Args.Length < 1)
                    {
                        return "err: Not enough parameters\nUsage: /code <text>";
                    }
                    else
                    {
                        return WH.Talk("`" + string.Join(" ", Args) + "`");
                    }
                default:
                    return "err: Unknown command.";
            }
        }
    }
}
