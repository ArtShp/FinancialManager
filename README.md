# Financial Manager

## Name
Financial Manager

## Author
Artemiy Shipovalov. UK MFF, 2024

## Description
This is a simple financial manager. It can help you to manage your money.

## Functionality
- Manage income and expenses
- Use multiple currencies
- Use different cash facilities (cash, bank card, etc.)
- Split transactions into categories
- Analyze income and expenses
- Convert money

## Usage
Launch .exe file.

### Setup a DB connection
First you need to open or create a database (further: DB).

**Warning**: You should use **only** DBs created in this app! Otherwise, the correct operation of the application is **not** guaranteed!

#### Create a new DB
If you want to create a new DB, open file menu (in the menu strip), find the button "Create DB" and press on it (or use a shortcut *Ctrl+N*). Then choose a folder where to store your DB, choose a name for it and finally press "Save". If everything is ok, you'll see a successful message. But then you'll immediately see a "Main Currency" error: about it later.

#### Open an existing DB
If you want to open an existing DB, open file menu (in the menu strip), find the button "Open DB" and press on it (or use a shortcut *Ctrl+O*). Then choose a DB file and press "Open". If everything is ok, you'll see a successful message. It's possible, that you'll immediately see a "Main Currency" error: about it later.

### Setup the Main Currency
When you have a new DB, first you need to do is to setup the Main Currency. Main Currency — currency that is used for storing all money operations. This is necessary, because there is a need of common currency for analytics. All money operations are stored both in currency you've chosen and the Main Currency.

**Warning**: The Main Currency is set for a specific DB **only once**. In future it **can't** be changed!

**Warning**: If the Main Currency is not set, the application **can't** work properly!

To setup it up, press "Edit Currencies" button and the form for editing currencies will be shown. You need to add a new currency and it will be the main one. About editing currencies read further.