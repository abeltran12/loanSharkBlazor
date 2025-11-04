# 🏠 Mortgage Loan Calculator

## 🧮 Functional Requirements

### Input Parameters
Develop a Mortgage Loan Calculator that accepts the following parameters:

- **Balance**: The total amount of money loaned, in dollars.
- **Term**: The repayment period of the loan, in months.
- **Rate**: The annual percentage rate (APR) at which interest accrues on the loan.

### Monthly Output
For each month of the loan, the calculator should display:

- **Month** — from 1 (first payment) to the total number of months
- **Monthly Payment Amount**
- **Principal Paid** for the current month
- **Interest Paid** for the current month
- **Total Interest Paid to Date**
- **Remaining Balance** at the end of the month

### Loan Summary
Additionally, display a summary that includes:

- **Total Monthly Payment** amount
- **Total Principal** borrowed
- **Total Interest Paid** over the lifetime of the loan
- **Total Cost** of the loan after full repayment

---

## ⚙️ Technical Requirements

The project must satisfy the following criteria:

- ✅ Built using **Blazor**, **HTML**, **CSS**, and **Bootstrap**
- ✅ The UI must be **fully responsive** across all screen sizes (desktop, tablet, and mobile)
- ✅ All source code must be hosted in a **public GitHub repository**

---

## 🚀 Getting Started

### Prerequisites

- **.NET 9 SDK** or higher

### Installation & Run

1. **Clone the repository**
```bash
   git clone https://github.com/abeltran12/loanSharkBlazor.git
```

2. **Navigate to the project directory**
```bash
   cd MortageBlazor
```

3. **Build the project**
```bash
   dotnet build
```

4. **Run the application**
```bash
   dotnet run
```

5. **Open your browser** and navigate to `https://localhost:5269` (or the URL shown in your terminal)

## 📸 Screenshots

Home Page

<img width="960" height="439" alt="image" src="https://github.com/user-attachments/assets/8700ae7b-17aa-4caf-af46-ab3a08291bbb" />

Loan Page

<img width="960" height="439" alt="image" src="https://github.com/user-attachments/assets/a17914dd-b60c-4546-b42e-a8b1316092c5" />

## 🛠️ Technologies Used

- Blazor
- HTML5
- CSS3
- Bootstrap 5

## 📝 License

MIT License

Copyright (c) 2025

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
