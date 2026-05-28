# 🎮 Tic-Tac-Toe Game

> Second WinForms desktop application — a fully interactive two-player Tic-Tac-Toe game built with C# and .NET Framework as part of Course 14 (C# Level 1) in the Programming Advices roadmap.

---

## 🖼️ Application Preview

<img width="800" height="523" alt="image" src="https://github.com/user-attachments/assets/72dbcee5-a24e-4bb6-a3f7-acee1616d1d5" />

---

## 🚀 Project Overview

This project is not just a game.

It is a practical exercise in connecting controls together,
understanding how events flow through a form,
and learning techniques that reduce code dramatically.

The game supports two players on the same machine.
Each player places their symbol in turns.
The game detects winners, handles draws, highlights winning cells,
and resets cleanly with a single button.

---

## 🏗️ Application Structure

```
┌──────────────────────────────────────────────────┐
│              Tic-Tac-Toe Game                    │
│                                                  │
│  Turn         [ ? ] | [ ? ] | [ ? ]              │
│  Player 1     ──────────────────                 │
│               [ ? ] | [ ? ] | [ ? ]              │
│  Winner       ──────────────────                 │
│  In Progress  [ ? ] | [ ? ] | [ ? ]              │
│                                                  │
│  [ Restart Game ]                                │
└──────────────────────────────────────────────────┘
```

The game grid is drawn manually on the form using
`Graphics.DrawLine()`
with a custom white pen and rounded line caps.

---

## ⚙️ Core Functionalities

| Feature | Description |
|---|---|
| Two-Player Mode | Players alternate turns on the same machine |
| Turn Indicator | Live label showing whose turn it is |
| Winner Detection | Checks all 8 win combinations after every move |
| Draw Detection | Triggers when all 9 cells are filled with no winner |
| Visual Win Highlight | Winning cells change to GreenYellow |
| Invalid Move Prevention | Wrong cell click triggers a warning MessageBox |
| Disable After Game Over | All buttons disabled when game ends |
| Restart Button | Resets all cells, labels, and state instantly |

---

## 🧠 Key Technical Concepts

### Custom Form Drawing
The grid lines are drawn directly on the form using the
`Paint`
event and
`Graphics.DrawLine()`.

```csharp
Pen WhitePen = new Pen(Color.White);
WhitePen.Width = 13;
WhitePen.StartCap = LineCap.Round;
WhitePen.EndCap = LineCap.Round;

e.Graphics.DrawLine(WhitePen, 615, 160, 615, 615); // vertical line 1
e.Graphics.DrawLine(WhitePen, 415, 310, 1050, 310); // horizontal line 1
```

---

### Images Loaded from Resources
X, O, and QuestionMark images are embedded in the project
`Resources`
and assigned directly to button images.

```csharp
btn.Image = Resources.QuestionMark;
btn.Image = Resources.X;
btn.Image = Resources.O;
```

---

### Tag Property for Cell State
Each button stores its current state in the
`Tag`
property — either
`"?"`, `"X"`, or `"O"`.

This removes the need for a separate array and connects the UI directly to the logic.

```csharp
btn.Tag = "X";
if (btn1.Tag.ToString() == btn2.Tag.ToString()) { ... }
```

---

### Single Event Handler for All 9 Buttons
Instead of writing 9 separate click handlers, all buttons share one method.

The
`sender`
parameter is cast to
`Button`
and passed to
`ChangeImage()`.

```csharp
// All 9 buttons point to the same event
private void button_Click(object sender, EventArgs e)
{
    ChangeImage((Button)sender);
}
```

This is one of the most important techniques taught in this project.

Any control that triggers an event passes itself as
`sender`.
Casting it gives full access to that control — no need to know which button was clicked.

---

### Enums and Struct for Game State
Game state is organized cleanly using enums and a struct.

```csharp
enum enPlayerTurn  { Player1, Player2 }
enum enWinner      { Player1, Player2, Draw, GameInProgress }

struct stGameStatus
{
    public enWinner Winner;
    public byte PlayCount;
    public bool GameOver;
}
```

---

### Win Detection — 8 Combinations
All 8 possible win paths are checked after every move
using a single reusable function.

```csharp
private bool CheckValues(Button btn1, Button btn2, Button btn3)
{
    if (btn1.Tag.ToString() != "?" &&
        btn1.Tag.ToString() == btn2.Tag.ToString() &&
        btn1.Tag.ToString() == btn3.Tag.ToString())
    {
        btn1.BackColor = Color.GreenYellow;
        btn2.BackColor = Color.GreenYellow;
        btn3.BackColor = Color.GreenYellow;
        // set winner and end game
        return true;
    }
    return false;
}
```

The function is called 8 times — rows, columns, and diagonals.

---

### Controls as Parameters
Functions that modify controls accept
`Button`
as a parameter.

Since controls are reference types, any change inside the function
affects the actual control on the form — no return value needed.

```csharp
private void ResetButton(Button btn)
{
    btn.Enabled = true;
    btn.Image = Resources.QuestionMark;
    btn.Tag = "?";
    btn.BackColor = Color.Transparent;
}
```
# 🍕 Pizza Order Form

> First WinForms desktop application — built with C# and .NET Framework as part of Stage Two of the programming roadmap.

---

## 🚀 Project Overview

This is the first **Windows Forms** project in the roadmap.

After completing Stage One (13 courses in C++, Algorithms, OOP, and Data Structures),
Stage Two begins with C# and .NET Framework — using desktop development as a structured learning tool.

This project is not just about pizza.

It is about understanding:

- How visual controls work
- How events connect UI to logic
- How state is managed across a form
- How clean code principles apply in a GUI environment

The application allows a user to fully customize a pizza order
and see the result update in real time — just like a real ordering system.

---

## 🖼️ Application Preview

<img width="800" height="504" alt="image" src="https://github.com/user-attachments/assets/c404c0a5-1572-420d-b68e-16c5fb10272a" />


---

## 🏗️ Application Structure

The form is organized into four selection areas and one live summary panel:

```
┌─────────────────────────────────────────────────────────┐
│  Size          Toppings               Order Summary      │
│  ─────         ────────               ─────────────      │
│  Small         Extra Cheese  Onion    Size               │
│  Medium        Mushrooms     Olives   Toppings           │
│  Large         Tomatoes      GreenP   Crust Type         │
│                                       Where To Eat       │
│  Crust Type    Where To Eat           Total Price        │
│  ─────────     ────────────                              │
│  Thin Crust    Eat In                                    │
│  Thick Crust   Take Out                                  │
│                                                          │
│          [ Order Pizza ]   [ Reset Form ]                │
└─────────────────────────────────────────────────────────┘
```

---

## ⚙️ Core Functionalities

| Feature | Description |
|---|---|
| Size Selection | Small / Medium / Large — each with its own price |
| Crust Type | Thin Crust / Thick Crust |
| Toppings | 6 options — any combination, each with its own price |
| Where To Eat | Eat In / Take Out |
| Order Summary | Updates in real time on every selection change |
| Total Price | Recalculated instantly using Tag-based pricing |
| Order Pizza | Confirmation dialog → disables all controls on confirm |
| Reset Form | Restores all defaults and re-enables controls |

---

## 🧠 Key Technical Concepts Practiced

### Controls Used
- `GroupBox` — logical grouping of related controls
- `RadioButton` — single-choice selections (Size, Crust, Where To Eat)
- `CheckBox` — multi-choice selections (Toppings)
- `Label` — dynamic display of summary and total price
- `Button` — triggering actions (order and reset)
- `MessageBox` — user confirmation and feedback

### Event-Driven Programming
Each control change is connected to an event handler.

The form responds immediately — no submit button is needed to update the summary.

```csharp
private void rbSmall_CheckedChanged(object sender, EventArgs e) => UpdateSize();
private void chkExtraChees_CheckedChanged(object sender, EventArgs e) => UpdateToppings();
```

### Tag-Based Pricing
Prices are stored directly in the `Tag` property of each control.
No hardcoded price tables. No switch statements.

```csharp
private float GetSelectedSizePrice()
{
    if (rbSmall.Checked) return Convert.ToSingle(rbSmall.Tag);
    else if (rbMedium.Checked) return Convert.ToSingle(rbMedium.Tag);
    else return Convert.ToSingle(rbLarge.Tag);
}
```

### Clean Code — Divide and Conquer
Each responsibility is isolated in its own method:

```
UpdateSize()         → reads size, updates label
UpdateCrustType()    → reads crust, updates label
UpdateToppings()     → builds toppings string, updates label
UpdateWhereToEat()   → reads dining option, updates label
UpdateTotalPrice()   → calculates and displays price
UpdateOrderSummary() → calls all update methods together
```

No single method does more than one thing.

### State Management
- **Ordering**: disables all controls — prevents changes after confirming
- **Resetting**: re-enables all controls and restores default selections

---

## 🎯 What This Project Teaches

- Real-world structure of a WinForms application
- Event-driven thinking (react to user actions)
- UI state management (enable / disable / reset)
- Clean function decomposition inside a GUI project
- Connecting visual controls to backend logic

---
