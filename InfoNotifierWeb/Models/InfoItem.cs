using System;
using System.ComponentModel.DataAnnotations;

namespace InfoNotifierWeb.Models
{
    public class InfoItem
    {
        public Guid Id { get; set; }

        public bool IsFinal { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTimeOffset? ItemDate { get; set; }
    }
}