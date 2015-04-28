using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdsm.api;
using tdsm.api.Plugin;


namespace SlackPlugin
{
    public class SlackPlugin : BasePlugin
    {
        private static string _channel = "";
        private static string _webhook = "";
        private static string _userName = "TerrariaBot";
        private static string _iconEmoji = ":terraria:";

        public static readonly SlackClient instance = new SlackClient(_webhook); 
        

        public SlackPlugin() {
            this.TDSMBuild = 1;
            this.Version = "1";
            this.Author = "swrhim";
            this.Name = "Slack Notification Plugin";
            this.Description = "This plugin will notify a slack channel of users logging in and out";
        }

        [Hook(HookOrder.NORMAL)]
        void AlertSignIn(ref HookContext ctx, ref HookArgs.PlayerEnteredGame args) {
            string msg = String.Format("User: {0} has joined", ctx.Player.name);
            instance.SendMessage(msg, _userName, _channel, _iconEmoji);
        }

        [Hook(HookOrder.NORMAL)]
        void AlertSignOut(ref HookContext ctx, ref HookArgs.PlayerLeftGame args) {
            string msg = String.Format("User: {0} has left :(", ctx.Player.name);
            instance.SendMessage(msg, _userName, _channel, _iconEmoji);
        }

        [Hook(HookOrder.NORMAL)]
        void AlertIP(ref HookContext ctx, ref HookArgs.PlayerLeftGame args) {
            string msg = String.Format("User: {0} has left :(", ctx.Player.name);
            instance.SendMessage(msg, _userName, _channel, _iconEmoji);
        }

    }
}
