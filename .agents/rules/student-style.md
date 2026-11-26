---
trigger: always_on
---

# 2nd-Year IT Student Coding Style

Keep all C# and WinForms code generated for this workspace super simple, beginner-friendly, and strictly within what a 2nd-year IT student uses:

1. **Use Basic C# Constructs Only**
   - Use standard `if / else if / else`, `switch`, `for`, and `foreach` loops.
   - Use normal named event handler methods (e.g., `txtSearch_TextChanged`, `dgvRooms_CellClick`) instead of lambda expressions (`=>`).
   - Use standard object instantiation (`MySqlConnection conn = new MySqlConnection(connStr);`) and basic `try / catch (Exception ex)` with `finally` to close the connection.

2. **Avoid Advanced or Over-Engineered Features**
   - Do NOT use LINQ (`.Where()`, `.Select()`, `.Average()`, etc.), switch expressions, tuple deconstruction, pattern matching (`is not`, `when`), target-typed `new()`, `init` properties, `StringBuilder`, `CultureInfo`, `Math.Clamp`, or nested `sealed` classes.
   - Do NOT use complex `DataGridView` pixel hit-testing (`GetCellDisplayRectangle`, `PointToClient`) or custom `CellFormatting` graphics/tuples. Keep grid interactions simple (e.g., `dgvRooms_CellClick` with `MessageBox` options or simple helper dialogs).
