using System.Text.Json;

public class Address
{
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
}

public class Course
{
    public string Code { get; set; }
    public string Name { get; set; }
}

public class DataMahasiswa_2311104056
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public Address Address { get; set; }
    public List<Course> Courses { get; set; }

    public void ReadJSON()
    {
        string filePath = "jurnal7_1_2311104056.json";
        try
        {
            string jsonData = File.ReadAllText(filePath);
            var mahasiswa = JsonSerializer.Deserialize<DataMahasiswa_2311104056>(jsonData);

            Console.WriteLine($"Name: {mahasiswa.FirstName} {mahasiswa.LastName}");
            Console.WriteLine($"Gender: {mahasiswa.Gender}");
            Console.WriteLine($"Age: {mahasiswa.Age}");
            Console.WriteLine($"Address: {mahasiswa.Address.StreetAddress}, {mahasiswa.Address.City}, {mahasiswa.Address.State}");
            Console.WriteLine("Courses:");

            foreach (var course in mahasiswa.Courses)
            {
                Console.WriteLine($"  - {course.Code}: {course.Name}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading JSON: " + ex.Message);
        }
    }
}