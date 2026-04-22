using Microsoft.AspNetCore.Mvc;
using Dapper;

[ApiController]
[Route("api/[controller]")]
public class AyamController : ControllerBase
{
    private readonly DbContext _context;

    public AyamController(DbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        using var db = _context.CreateConnection();
        var data = db.Query("SELECT * FROM ayam");

        return Ok(new { status = "success", data });
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        using var db = _context.CreateConnection();
        var data = db.QueryFirstOrDefault("SELECT * FROM ayam WHERE id=@id", new { id });

        if (data == null)
            return NotFound(new { status = "error", message = "Data tidak ditemukan" });

        return Ok(new { status = "success", data });
    }

    [HttpPost]
    public IActionResult Create([FromBody] Ayam ayam)
    {
        using var db = _context.CreateConnection();
        db.Execute("INSERT INTO ayam (jenis, umur, kandang_id, pakan_id) VALUES (@Jenis,@Umur,@Kandang_Id,@Pakan_Id)", ayam);

        return Ok(new { status = "success", message = "Data berhasil ditambahkan" });
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Ayam ayam)
    {
        using var db = _context.CreateConnection();
        db.Execute("UPDATE ayam SET jenis=@Jenis, umur=@Umur WHERE id=@id",
            new { ayam.Jenis, ayam.Umur, id });

        return Ok(new { status = "success", message = "Data berhasil diupdate" });
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        using var db = _context.CreateConnection();
        db.Execute("DELETE FROM ayam WHERE id=@id", new { id });

        return Ok(new { status = "success", message = "Data berhasil dihapus" });
    }
}