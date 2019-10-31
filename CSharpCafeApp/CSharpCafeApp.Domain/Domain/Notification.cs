using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCafeApp.Domain.Domain
{
    public enum AlertType
    {
        System = 0,
        User = 1,
        Contact = 2
    }

    public class Newsletter
    {
        public int Id { get; set; }
        public string Email { get; set; }
    }

    public class Notification
    {
        public int Id { get; set; }

        public int AuthorId { get; set; }

        public AlertType AlertType { get; set; }

        public string Content { get; set; }

        public DateTime NotifiedDate { get; set; }

        public string Notifier { get; set; }

        public bool Active { get; set; }
    }
}
