using System.ComponentModel.DataAnnotations;

namespace RemoteConfigTraining.Domain
{
    public class Feature
    {
        [Key]
        public int Id { get; set; }
        public string Key { get; set; }

        public string Value { get; set; }

    }
}