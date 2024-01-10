using SQLite;
namespace patron_prototipo_ejemplo.Data;
public class FiguresService
{
    string _dbPath;
    public string StatusMessage { get; set; }
    private SQLiteAsyncConnection conn;
    public FiguresService(string dbPath)
    {
        _dbPath = dbPath;
    }
    private async Task InitAsync()
    {
        // Don't Create database if it exists
        if (conn != null)
            return;
        // Create database and WeatherForecast Table
        conn = new SQLiteAsyncConnection(_dbPath);
        await conn.CreateTableAsync<Figure>();
    }
    public async Task<List<Figure>> GetFigureAsync()
    {
        await InitAsync();
        return await conn.Table<Figure>().ToListAsync();
    }
    public async Task<Figure> CreateFigureAsync(
        Figure paramWeatherForecast)
    {
        // Insert
        await conn.InsertAsync(paramWeatherForecast);
        // return the object with the
        // auto incremented Id populated
        return paramWeatherForecast;
    }
    public async Task<Figure> UpdateFigureAsync(
        Figure paramWeatherForecast)
    {
        // Update
        await conn.UpdateAsync(paramWeatherForecast);
        // Return the updated object
        return paramWeatherForecast;
    }
    public async Task<Figure> DeleteFigureAsync(
        Figure paramWeatherForecast)
    {
        // Delete
        await conn.DeleteAsync(paramWeatherForecast);
        return paramWeatherForecast;
    }
}