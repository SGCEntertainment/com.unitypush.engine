using Unity.Notifications.Android;
using UnityEngine;

public class NotifyCenter : MonoBehaviour
{
    private AndroidNotificationChannel channel;

    private void Start()
    {
        channel = new AndroidNotificationChannel
        {
             Id = "default_channel",
             Name = "Default Channel",
             Description = "For Generic Notifications",
             Importance = Importance.Default
        };

        AndroidNotificationCenter.RegisterNotificationChannel(channel);

        var notification = new AndroidNotification
        {
            Title = "Jackpot every day!",
            Text = "Jackpot every day! Slots are hot today. You'll be lucky!",
            LargeIcon = "icon_0",
            FireTime = System.DateTime.Now.AddSeconds(10)
        };

        AndroidNotificationCenter.SendNotification(notification, "default_channel");
    }
}
