using System.Text.Json ;

namespace WiredBrainCoffee.StorageApp.Entities
{
    public static class EntityExtensions
    {
        public static T copyEntity<T>(this T entity)
        where T : IEntity
        {
            var json = JsonSerializer.Serialize<T>(entity);

            return JsonSerializer.Deserialize<T>(json)  ;
        }
    }
}