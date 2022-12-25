// See https://aka.ms/new-console-template for more information
using notifier;

Console.WriteLine("notifier library usage");

// create notification requests with the type of return value using the INotifyRequest
INotifyRequest<Guid> emailRequest = new EmailNotifyRequest
{
    FromEmail = @"test@test.com",
    ToEmail = @"test@gmail.com",
    Subject = "test email",
    Body = "test body"
};

INotifyRequest<Guid> pushRequest = new PushNotifyRequest
{
    Title = "test title",
    Body = "push notification content",
    IsAndroidDevice = true
};

INotify notifier = new Notifier();  // mediator

try
{
    var emailRes = await notifier.Send(emailRequest);
    var pushRes = await notifier.Send(pushRequest);

    Console.WriteLine($"email sent {emailRes}");
    Console.WriteLine($"push notification sent {pushRes}");
}
catch (Exception ex)
{
    Console.WriteLine($"notification send failed - {ex.ToString()}");
}



