
## 🎯 What Built — Full System!
```
ACLEDABank Project
├── 🏗️ MVC Architecture
│   ├── HomeController (Views + Forms)
│   ├── AccountsController (REST API)
│   └── Razor Views (.cshtml)
│
├── 🧩 OOP Design
│   ├── BankAccount (Encapsulation)
│   ├── SavingAccount (Inheritance)
│   ├── LoanAccount (Inheritance)
│   └── IBankService (Abstraction)
│
├── 🗄️ SQL Database
│   ├── tblBankAccounts
│   ├── Stored Procedures (SP_*)
│   └── EF Core Connection
│
├── 🔌 REST API
│   ├── GET /api/accounts
│   ├── POST /api/accounts
│   ├── PUT /api/accounts/{id}
│   └── DELETE /api/accounts/{id}
│
└── 📦 Git Flow
    ├── git add → commit → push
    └── Full history on GitHub ✅
```

---

## 📋 

### MVC:
```
Model      = Data & business logic
View       = UI (.cshtml Razor)
Controller = handles requests
[HttpGet]  = show page
[HttpPost] = receive form data
```

### OOP:
```
Encapsulation = private + public methods
Inheritance   = ChildClass : ParentClass
Polymorphism  = virtual + override
Abstraction   = interface IBankService
```

### SQL:
```
SELECT = read    | INSERT = create
UPDATE = edit    | DELETE = remove
WHERE  = filter  | JOIN   = combine tables
SP_    = stored procedure prefix
```

### API:
```
GET    = read    → 200 OK
POST   = create  → 201 Created
PUT    = update  → 200 OK
DELETE = remove  → 200 OK
404    = not found
500    = server error
```

### Git:
```
git add .        = pack changes
git commit -m "" = save snapshot
git push         = upload to GitHub
git status       = check changes
```
