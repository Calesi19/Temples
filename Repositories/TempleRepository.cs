using Temples.Data.Models;

namespace Temples.Repositories;
using System.Data;
using Dapper;

public class TempleRepository: ITempleRepository
{
    private readonly IDbConnection _dbConnection;

    public TempleRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public async Task<IEnumerable<Temple>> FindAll()
    {
        var sql = "SELECT temple_id AS TempleId, temple_name AS TempleName, country AS Country, state AS State, city AS City, address_line1 AS AddressLine1, address_line2 AS AddressLine2, postal_code AS PostalCode, dedication_day AS DedicationDay, dedication_year AS DedicationYear, dedication_month AS DedicationMonth, announcement_day AS AnnouncementDay, announcement_month AS AnnouncementMonth, announcement_year AS AnnouncementYear, status AS Status, image_url AS ImageUrl, description AS Description, phone AS Phone, latitude AS Latitude, longitude AS Longitude, google_maps_link AS GoogleMapsLink FROM temples";
        return await _dbConnection.QueryAsync<Temple>(sql);
    }

    public async Task<Temple> FindById(Guid id)
    {
        var sql = "SELECT temple_id AS TempleId, temple_name AS TempleName, country AS Country, state AS State, city AS City, address_line1 AS AddressLine1, address_line2 AS AddressLine2, postal_code AS PostalCode, dedication_day AS DedicationDay, dedication_year AS DedicationYear, dedication_month AS DedicationMonth, announcement_day AS AnnouncementDay, announcement_month AS AnnouncementMonth, announcement_year AS AnnouncementYear, status AS Status, image_url AS ImageUrl, description AS Description, phone AS Phone, latitude AS Latitude, longitude AS Longitude, google_maps_link AS GoogleMapsLink FROM temples WHERE temple_id = @Id";
        return await _dbConnection.QueryFirstOrDefaultAsync<Temple>(sql, new { Id = id });
    }


    public async Task<Guid> Create(Temple temple)
{
    var sql = @"
        INSERT INTO temples (
            temple_name, 
            country, 
            state, 
            city, 
            address_line1, 
            address_line2, 
            postal_code, 
            dedication_day, 
            dedication_year, 
            dedication_month, 
            announcement_day, 
            announcement_month, 
            announcement_year, 
            status, 
            image_url, 
            description, 
            phone, 
            latitude, 
            longitude, 
            google_maps_link
        ) VALUES (
            @TempleName, 
            @Country, 
            @State, 
            @City, 
            @AddressLine1, 
            @AddressLine2, 
            @PostalCode, 
            @DedicationDay, 
            @DedicationYear, 
            @DedicationMonth, 
            @AnnouncementDay, 
            @AnnouncementMonth, 
            @AnnouncementYear, 
            @Status, 
            @ImageUrl, 
            @Description, 
            @Phone, 
            @Latitude, 
            @Longitude, 
            @GoogleMapsLink
        ) RETURNING temple_id";
    return await _dbConnection.ExecuteScalarAsync<Guid>(sql, temple);
}

public async Task<bool> Update(Temple temple)
{
    var sql = @"
        UPDATE temples SET 
            temple_name = @TempleName, 
            country = @Country, 
            state = @State, 
            city = @City, 
            address_line1 = @AddressLine1, 
            address_line2 = @AddressLine2, 
            postal_code = @PostalCode, 
            dedication_day = @DedicationDay, 
            dedication_year = @DedicationYear, 
            dedication_month = @DedicationMonth, 
            announcement_day = @AnnouncementDay, 
            announcement_month = @AnnouncementMonth, 
            announcement_year = @AnnouncementYear, 
            status = @Status, 
            image_url = @ImageUrl, 
            description = @Description, 
            phone = @Phone, 
            latitude = @Latitude, 
            longitude = @Longitude, 
            google_maps_link = @GoogleMapsLink
        WHERE temple_id = @TempleId";
    var affectedRows = await _dbConnection.ExecuteAsync(sql, temple);
    return affectedRows > 0;
}

public async Task<bool> DeleteById(Guid id)
{
    var sql = "DELETE FROM temples WHERE temple_id = @Id";
    var affectedRows = await _dbConnection.ExecuteAsync(sql, new { Id = id });
    return affectedRows > 0;
}

}