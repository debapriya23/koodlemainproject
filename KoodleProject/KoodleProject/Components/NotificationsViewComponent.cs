﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core.Models;
using Services.Notifications;
using Services.Users;

namespace Web.Components
{
    public class NotificationsViewComponent : ViewComponent
    {
        private readonly INotificationService _notificationService;
        private readonly IUserService _userService;

        public NotificationsViewComponent(INotificationService notificationService, IUserService userService)
        {
            _notificationService = notificationService;
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var recipientId = await _userService.GetCurrentUserIdAsync();
            
            var (notifications, loadMore) =
                await _notificationService.GetPagedNotificationsAsync(recipientId);

            var model = new NotificationTemplateModel
            {
                LoadMore = loadMore,
                Notifications = notifications,
                TotalUnReadNotifications = await _notificationService.GetTotalUnReadNotificationsAsync(recipientId)
            };

            return View(model);
        }
    }
}