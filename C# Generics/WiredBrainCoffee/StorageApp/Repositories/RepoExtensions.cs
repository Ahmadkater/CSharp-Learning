
namespace WiredBrainCoffee.StorageApp.Repo
{
    public static class RepoExtensions
    {

        // Extension method for IWriteRepo<T> interface
        public static void addBatch<T> (this IWriteRepo<T> repo , T[] entities)
        {
            foreach (var e in entities)
            {
                repo.Add(e);

            }

            repo.Save();
        }
    }
}