---
trigger: always_on
---

# Project Database Connection & Query Conventions

Follow the instructor-mandated `MySql.Data.MySqlClient` structure used in `AdminUserManagement.cs` when generating database code for this workspace:

1. **Connection & Command Setup**
   - Use `MySqlConnection` with `"server=localhost; database=metro_care_db; uid=root"`.
   - Instantiate `MySqlCommand cmd = new MySqlCommand();`, set `cmd.CommandText = ...;` and `cmd.Connection = conn;` explicitly, and open/close with `conn.Open();` and `conn.Close();` (with `try`/`catch` and connection cleanup in `finally` when handling errors).

2. **Loading Grid Data (`loaddata()`)**
   - Use `DataSet` and `MySqlDataAdapter` (`da.SelectCommand = cmd; da.Fill(ds, "<tableAlias>");`), assigning `DataSource = ds` and `DataMember = "<tableAlias>"` when binding directly to a `DataGridView`, or `MySqlDataReader` (`cmd.ExecuteReader()`) when populating custom rows or reading single records (`reader.Read()` / `reader.HasRows`).

3. **Insert / Update Confirmation Flow**
   - Prompt with `MessageBox.Show("Do you want to save records?", "Saving Records", MessageBoxButtons.YesNo, MessageBoxIcon.Question)` before executing `cmd.ExecuteNonQuery()`.
   - Show `"RECORD SAVE"` confirmation after saving and refresh via `loaddata()`.

4. **Query Construction**
   - Keep queries plain, explicit SQL statements matching the class style (e.g., `SELECT * FROM ...`, `INSERT INTO ... VALUES (...)`, `UPDATE ... SET ... WHERE ...`, `DELETE FROM ... WHERE ...`) using the `cmd.CommandText` / `cmd.Connection = conn` pattern.
