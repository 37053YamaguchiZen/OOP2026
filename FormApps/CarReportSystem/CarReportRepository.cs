using Microsoft.Data.Sqlite;
using System.Globalization;

namespace CarReportSystem;

public class CarReportRepository
{

    //Productsテーブルに対するDB操作をまとめたクラス
    //CRUD(Create / Read /Update / Delete)を担当する
    public List<CarReport> GetAll() {

        var reports = new List<CarReport>();

        using var connection = CarReport.GetConnection();
        connection.Open();

        //SQLを実行するためのコマンドオブジェクトを作る
        using var command = connection.CreateCommand();

        //Productsテーブルを作るSQL
        command.CommandText =
            """
            SELECT Id, ,Date, Author, Maker, CarName,Report, Picture
            FROM CarReports
            ORDER BY Id;
            """;

        //SELECTを実行し、複数行の検索結果を読み取る
        using var reader = command.ExecuteReader();

        while (reader.Read()) {
            reports.Add(new CarReport {
                Id = reader.GetInt32(0),    //0列目:Id
                Date = DateTime.ParseExact(
                    reader.GetString(1),
                    "yyyy-mm-dd",
                    CultureInfo.InvariantCulture),  //1列目:Name
                Author = reader.GetString(2),  //2列目:Price
                Maker = (CarReport.MakerGroup)reader.GetInt32(3),
                CarName = reader.String(4),
                Report = reader.String(5),
                //Picture = (6)

            });
        }
        return reports;
    }

    public int Add(string name, int price) {
        //接続オブジェクトを生成する。
        using var connection = CarReport.GetConnection();
        connection.Open();
        using var command = connection.CreateCommand();

        command.CommandText =
            """
            INSERT INTO CarReports (Date, Author, Maker, CarName, Report, Picture)
            VALUES ($date, $author, $maker, $carName, $report, $picture);

            SELECT last_insert_rowid();
            """;

        command.Parameters.AddWithValue("$name", name);
        command.Parameters.AddWithValue("$price", price);

        //一つの値を返すSQLを実行する
        var result = command.ExecuteScalar();

        if(result is null)
            throw new InvalidOperationException("登録した商品のIDを取得できませんでした。");

        //SQLiteのINTEGERはlongとして返るため、intへ変換する
        return Convert.ToInt32((long)result);

    }
    public void Update(CarReport report) {
        //接続オブジェクトを生成する。
        using var connection = CarReport.GetConnection();
        connection.Open();
        using var command = connection.CreateCommand();

        command.CommandText =
            """
            UPDATE CarReports
            SET Date = $date, Author = $author, Maker = $maker,
                CarName = $carName, Report = $report, Picture = $picture
            WHERE Id = $id;
            """;

        command.Parameters.AddWithValue("$date",   report.Date);
        command.Parameters.AddWithValue("$author", report.Author);
        command.Parameters.AddWithValue("$maker",  report.Maker);
        command.Parameters.AddWithValue("$carName", report.CarName);
        command.Parameters.AddWithValue("$report", report.Report);
        command.Parameters.AddWithValue("picture", report.Picture);

        //更新件数が0なら対象が存在しない
        if (command.ExecuteNonQuery() == 0)
            throw new InvalidOperationException("修正対象の商品が見つかりませんでした。");　
    }
    
    public void Delete(int id) {
        using var connection = CarReport.GetConnection();
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText =

         """
         DELETE FROM CarReports
         WHERE Id = $id;
         """;

        command.Parameters.AddWithValue("$id", id);
        command.ExecuteNonQuery();
        
    }
}
