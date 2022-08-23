using System.Data;
using System.IO;
using System;
using System.Windows.Forms;
public class file_handler {
    public BindingSource file_to_table(FileStream _file) {

        DataSet dtSet = new DataSet();
        DataTable dt = new DataTable("Users");
        DataColumn _col;
        DataRow _row;

        #region Init tabla

        // Generando Columna 1 [ID]
        {
            _col = new DataColumn("id", typeof(Int32));
            _col.ReadOnly = false;
            _col.Unique = true;

            dt.Columns.Add(_col);
        }
        // Generando Columna 2 [name]
        {
            _col = new DataColumn("nombre", typeof(string));
            _col.ReadOnly = false;
            _col.Unique = false;

            dt.Columns.Add(_col);
        }
        // Generando Columna 3 [apellido]
        {
            _col = new DataColumn("apellido", typeof(string));
            _col.ReadOnly = false;
            _col.Unique = false;

            dt.Columns.Add(_col);
        }
        // Generando Columna 4 [email]
        {
            _col = new DataColumn("email", typeof(string));
            _col.ReadOnly = false;
            _col.Unique = false;

            dt.Columns.Add(_col);
        }
        // Generando Columna 5 [gender]
        {
            _col = new DataColumn("sexo", typeof(string));
            _col.ReadOnly = false;
            _col.Unique = false;

            dt.Columns.Add(_col);
        }
        // Generando Columna 6 [ip_address]
        {
            _col = new DataColumn("ip_address", typeof(string));
            _col.ReadOnly = false;
            _col.Unique = false;

            dt.Columns.Add(_col);
        }

        #endregion

        DataColumn[] PrimaryKeyColumns = new DataColumn[1];
        PrimaryKeyColumns[0] = dt.Columns["id"];
        dt.PrimaryKey = PrimaryKeyColumns;

        dtSet.Tables.Add(dt);

        using (StreamReader reader = new StreamReader(_file))
        {
            string linea = reader.ReadLine();
            string[] valores = linea.Split(',');

            while (!(reader.EndOfStream))
            {
                linea = reader.ReadLine();
                valores = linea.Split(',');

                _row = dt.NewRow();
                _row["id"] = Int32.Parse(valores[0]);
                _row["nombre"] = valores[1];
                _row["apellido"] = valores[2];
                _row["email"] = valores[3];
                _row["sexo"] = valores[4];
                _row["ip_address"] = valores[5];

                dt.Rows.Add(_row);
            }
        }

        BindingSource bindSrc = new BindingSource();
        bindSrc.DataSource = dt;

        return bindSrc;
    }
}