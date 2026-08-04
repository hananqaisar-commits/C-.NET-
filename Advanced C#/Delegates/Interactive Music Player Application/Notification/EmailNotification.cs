using System;
using Notification.Notify;
namespace Notification.EmailNotification;

public class EmailNotification
{
    public event Action<Notification.Notify.Notification> NotificationEvent;
    public void SendEmailNotification(Notification.Notify.Notification notification) => NotificationEvent?.Invoke(notification);

    public void DisplayNotification(Notification.Notify.Notification notification)
    {
        Console.WriteLine($"\n {notification.Title}");
        Console.WriteLine($"Message : {notification.Message}");
    }
}