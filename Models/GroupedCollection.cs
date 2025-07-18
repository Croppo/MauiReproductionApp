using System.Collections.ObjectModel;

namespace MauiTabbedApp.Models
{
    /// <summary>
    /// A grouped collection
    /// </summary>
    public class GroupedCollection : List<SimpleItem>
    {
        public string Heading { get; set; }

        /// <summary>
        /// Creates a new instance of the <see cref="GroupedCollection"/> class.
        /// </summary>
        /// <param name="group"></param>
        /// <param name="items"></param>
        public GroupedCollection(string group, IEnumerable<SimpleItem> items) : base(items)
        {
            this.Heading = group;
        }
    }
}