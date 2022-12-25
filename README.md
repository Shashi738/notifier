
# Notifier Library

A library for sending notifications.






## 🔗 Links
[Github Notifier library](https://github.com/Shashi738/notifier/tree/dev_notifier)



## Notifier library uses below design patterns

- Mediator design pattern
- Factory method design pattern
- Strategy design pattern

The Notifier mediator abstracts direct communication between client and Notify handlers. So that both can vary independently of one another.

The Notifier mediator uses NotifyHandlerFactory to get the relevant notify handler based on the inpur request.

Notify handlers are implemented using the strategy design pattern.

## Usage/Examples

```
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
```

