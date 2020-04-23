using Finance.Core.DTOs;
using Finance.Service;
using Finance.UI.Views;
using System;

namespace Finance.UI.Controllers
{
    public class EventController
    {
        private readonly EventView view;
        private readonly EventService eventService;
        private readonly UserService userService;
        private readonly UserDto loggedUser;

        public EventController(EventView view)
        {
            this.view = view;
            this.view.SetController(this);
            eventService = new EventService();
            userService = new UserService();
            loggedUser = userService.GetUser(Environment.UserName);
        }

        public void Init()
        {

        }

        public void Show()
        {
            view.Show();
        }
    }
}
