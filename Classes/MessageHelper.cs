using System.Drawing;
using System.Windows.Forms;

namespace E_Shop.Classes
{
    internal static class MessageHelper
    {
        public static void PrintOutMessage(string message, Label label, MessageType type = MessageType.Success)
        {
            label.Text = message;

            switch (type)
            {
                case MessageType.Success:
                    label.ForeColor = Color.Green;
                    break;
                case MessageType.Error:
                    label.ForeColor = Color.Red;
                    break;
                case MessageType.Warning:
                    label.ForeColor = Color.Orange;
                    break;
                default:
                    label.ForeColor = Color.Black;
                    break;
            }
        }
    }

    public enum MessageType
    {
        Success,
        Error,
        Warning,
        Info
    }
}
