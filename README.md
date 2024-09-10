﻿# Financial Manager

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

### Setup CurrencyAPI key
Next step is to setup the key for currency exchange service. Here we use [this](https://currencyapi.com) free service. You will need to setup your own API key. Here is an absolutely free variant of account and it's enough for our needs. It provides 300 requests/month and 10 request/minute, a big variety of more than 170 world currencies and ability to get currencies exchange rate not only for today, but also for previous days.

Firstly you need to create an account (choose variant with a free subscription). After completing the registration you'll see the API key in dashboard. Save it, you will need it further.

Now you need to add it to the app settings. Find the button "CurrencyAPI key" in settings section, press it and the form for editing will be shown. Here is the field where you need to enter the key. When you press "Ok", the key will be checked and saved if it's correct.

**Notice**: This API key is **common** for all DBs, but **unique** for all users.

**Warning**: Without set up key the application **can't** work properly. You'll be able to do everything **except of** adding/editing Items and exchanging currencies. Also you'll have the same problems if the service is down or you don't have an internet connection.

### Fill other data
This is the last step before you can start using the application fully. You will need to fill other tables. Most of them have a common interface.

#### Edit forms interface
All of the edit forms (forms specified for editing data, in edit section) have a common interface.

##### Add
If you want to add some new item to the table, you need to fill all obligatory field and then press the "Add" button. If fields are filled correctly and in the table there are no similar records, new item will be added.

##### Edit
If you want to edit some item in the table, you need to select an item in the table and then press the "Edit" button. After it the data of this item will be loaded to the form fields. Then you should use either "Save" or "Cancel" button.

##### Save
If you're editing an item, you can change its data in the form fields. If you want to save changes, press the "Save" button. After it data in table will be changed (if the fields were filled correctly).

##### Cancel
If you're editing an item, but you don't want to dave changes, you can press the "Cancel" button and no changes will be applied.

##### Delete
If you want to delete some item in the table, you need to select an item in the table and then press the "Delete" button. After confirming the item will be deleted.

##### Refresh
If you want to refresh all data in the form (including table and other foreign data), press the "Refresh" button.

#### Edit Currencies
Every currency has Name, Code, Symbol and Units rate.
- Name — name of currency (e.g. *US Dollar* or *Czech Republic Koruna*)
- Code — code of currency according to ISO 4217 (and not only), (e.g. *USD* or *CZK*)
- Symbol — currency symbol (e.g. *$* or *Kč*)
- Units rate — by how much order the currency is broken down into. (e.g. *1$ = 100 cents*, so units rate = 2. But *1Ft (Hungarian Forint)* is not divided into subunits, so units rate = 0)

**Warning**: Currency code field is **very important**! If it's incorrect, the application **can't** work properly. Other field are not checked.

**Notice**: [Here](https://currencyapi.com/docs/currency-list) you can find the list of all supported currencies with their codes.

**Notice**: The Main Currency is highlighted in blue color. It **can't** be changed or deleted.

#### Edit Transaction Types
Transaction type can be Income or Expense. It's not possible to add a new or delete an existing transaction type. You have ability only to rename them.

#### Edit Places Of Purchases
This is a list of places where you buy goods (e.g. TESCO, McDonalds, FlixBus and etc.). There is a need for place of purchase mostly for expenses. For income you can choose nothing as place of purchase.

#### Edit Tags
Each tag has Name and Transaction Type. Tags can be used as universal signs for Items. For example, you can mark all spendings while travelling as *#Travelling* and then you'll have ability to easily find them or somehow analyze you spending while travelling. Tags have a limitless scope of use.

#### Edit Cash Facilities
Each cash facility has Name and Currency. Cash facility can be cash, bank card, bank account or whatever you want.

**Notice**: Each cash facility has **exactly** one assigned currency. If you have multi-currency cash facility, you'll need to add for each currency a separate cash facility.