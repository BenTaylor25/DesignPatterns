
namespace Observer
{
    class NotificationService
    {
        private SocialAccount owner;
        private List<SocialAccount> followers;

        public NotificationService(SocialAccount owner)
        {
            this.owner = owner;
            followers = new List<SocialAccount>();
        }

        public void NotifyPost()
        {
            foreach (var follower in followers)
            {
                follower.Notify($"[{owner.name} posted]");
            }
        }

        public void AddSubscriber(SocialAccount follower)
        {
            followers.Add(follower);
        }

        public void RemoveSubscriber(SocialAccount follower)
        {
            followers.Remove(follower);
        }
    }

    class SocialAccount
    {
        private NotificationService notificationService;

        public string name { get; }

        public SocialAccount(string name)
        {
            notificationService = new NotificationService(this);
            this.name = name;
        }

        public void Follow(SocialAccount toFollow)
        {
            toFollow.notificationService.AddSubscriber(this);
        }

        public void Unfollow(SocialAccount toUnfollow)
        {
            toUnfollow.notificationService.RemoveSubscriber(this);
        }

        public void MakePost()
        {
            Console.WriteLine($"{name}: [Posted]");
            notificationService.NotifyPost();
        }

        public void Notify(string message)
        {
            Console.WriteLine($"{name}: {message}");
        }
    }

    class Observer
    {
        public static void Execute()
        {
            SocialAccount alex = new("Alex");
            SocialAccount ben = new("Ben");
            SocialAccount charlie = new("Charlie");

            ben.Follow(alex);
            charlie.Follow(alex);

            alex.MakePost();
            // Alex: [Posted]
            // Ben: [Alex posted]
            // Charlie: [Alex posted]
            Console.WriteLine();

            ben.Unfollow(alex);
            ben.Unfollow(alex);   // to make sure it doesn't break

            alex.MakePost();
            // Alex: [Posted]
            // Charlie: [Alex posted]
        }
    }
}