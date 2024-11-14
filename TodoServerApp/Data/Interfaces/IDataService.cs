using TodoServerApp.Components.Pages;

namespace TodoServerApp.Data.Interfaces
{
    public interface IDataService
    {
        Task<IEnumerable<TaskItem>> GetAllAsync();
        Task SaveAsync(TaskItem item);
        Task<TaskItem> GetTaskAsync(int id);
        Task DeleteAsync(int id);
    }

    public interface IDataServiceUser
    {
        Task<IEnumerable<UserElement>> GetUserElementsAsync();
       /* Task SaveAsync(TaskItem item);
        Task<TaskItem> GetTaskAsync(int id);
        Task DeleteAsync(int id);*/
    }
}
