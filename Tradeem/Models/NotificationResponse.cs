using System;
using System.Collections.Generic;

namespace Tradeem.Models
{
    public class NotificationResponse
    {
        public String Action { get; set; }
        public String State { get; set; }
        public String Message { get; set; }
//        public String NotificationList { get; set; }
        public List<NotificationList> NotificationList { get; set; }
        public String Error { get; set; }

/*        public NotificationResponse()
        {
        }
*/  }
}
