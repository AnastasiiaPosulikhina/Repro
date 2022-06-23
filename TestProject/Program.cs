// See https://aka.ms/new-console-template for more information

using Moq;

var mock = new Mock<IRepository>();
mock.Setup(repo=>repo.GetAll()).Returns(new List<User>
{
    new User { Id=1, Name="Tom", Age=35},
    new User { Id=2, Name="Alice", Age=29},
    new User { Id=3, Name="Sam", Age=32},
    new User { Id=4, Name="Kate", Age=30}
});

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

public interface IRepository
{
    IEnumerable<User> GetAll();
    User Get(int id);
    void Create(User user);
    
    
}