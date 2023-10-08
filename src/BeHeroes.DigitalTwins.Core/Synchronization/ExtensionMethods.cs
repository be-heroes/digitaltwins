using System.Text.Json;

namespace BeHeroes.DigitalTwins.Core.Synchronization
{
    //TODO: Migrate to BeHeroes.CodeOps.Abstractions package in ExtensionMethods namespace
    public static class ExtensionMethods
    {
        /// <summary>
        /// Creates a deep copy of the specified object using JSON serialization and deserialization.
        /// </summary>
        /// <typeparam name="T">The type of the object to copy.</typeparam>
        /// <param name="self">The object to copy.</param>
        /// <returns>A deep copy of the specified object.</returns>
        public static T DeepCopy<T>(this T self)
        {
            var serialized = JsonSerializer.Serialize(self);
            
            return JsonSerializer.Deserialize<T>(serialized) ?? throw new ArgumentNullException(nameof(serialized));
        }
    }
}