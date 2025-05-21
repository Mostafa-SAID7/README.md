# 🙋‍♂️ Are You Ahmed?

A simple and fun C# console app that asks one question: **Are you Ahmed?**

This small program is perfect for beginners learning about:
- Console input/output
- Nullable booleans (`bool?`)
- Basic control flow and user input validation in C#

---

## 🧠 What Does It Do?

When you run the app, it will ask:

Are you Ahmed? : (Y,N)

You can respond with:
- `Y` or `y` → and it will assume you're Ahmed (`true`)
- `N` or `n` → you're not Ahmed (`false`)
- Anything else → and it'll tell you it's an invalid input and exit gracefully.

After your answer, it prints the result like:
Is Ahmed: True

---

## 📦 How to Run It

Make sure you have [.NET SDK](https://dotnet.microsoft.com/download) installed.
``
1. Clone the repo or copy the code into a `.cs` file inside a new .NET console app project.
2. Open your terminal in the project directory.
3. Run:
   ```bash
   dotnet run
💡 Why Nullable bool??
. Using bool? (nullable boolean) lets us represent three states:
- true (you are Ahmed)
- false (you're not)
- null (you haven't answered yet)
This can be useful when you need to show an "unknown" or "not answered yet" state before setting a value.
