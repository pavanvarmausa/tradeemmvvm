using System;
using System.Collections.Generic;
using RestSharp;
using Tradeem.Models;
//using Tradeem.Services;
//using Xamarin.Forms;

namespace Tradeem.ViewModels
{
    public class NotificationViewModel : BaseViewModel
    {
        public NotificationResponse notificationResponse { get; set; }
//        public List<Notification> notifications { get; set; }

        private List<NotificationList> _model;
        public List<NotificationList> NotificationList
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
                RaisePropertyChanged(() => NotificationList);
            }
        }

        public NotificationViewModel()
        {
            NotificationRequest notificationRequest = new NotificationRequest();
            notificationRequest.Action = "LoadNotifications";
            // notificationRequest.UserId = App.UserID;
            //notificationRequest.UserId = "1t8XbvfJARXT4k56Dj8wo3njC1d2";
            notificationRequest.UserId = "BekLRAawJMXlKcyDg1fYIXPjXTL2";
            RestClient client = new RestClient("https://tradeemwsapi.azurewebsites.net/api/notification");
            RestRequest request = new RestRequest();
            request.AddJsonBody(notificationRequest);
            request.Method = Method.POST;

            IRestResponse response = client.Execute(request);

            String json = response.Content; //json has our response

            RestSharp.Deserializers.JsonDeserializer deserial = new RestSharp.Deserializers.JsonDeserializer();

            notificationResponse = deserial.Deserialize<NotificationResponse>(response);

            NotificationList = notificationResponse.NotificationList;

//            Console.WriteLine("User ->"+notificationResponse.ToString());
//            Console.WriteLine("Json String" + json);
        }
    }
}
