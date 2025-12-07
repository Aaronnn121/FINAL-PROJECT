using System;
using System.Diagnostics;
using System.IO;

public static class ReceiptPrinter
{
    private static string FolderPath = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
        "BankReceipts"
    );

    static ReceiptPrinter()
    {
        if (!Directory.Exists(FolderPath))
            Directory.CreateDirectory(FolderPath);
    }

    private static string GenerateRef()
    {
        return "TX-" + Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper();
    }

    private static void SaveAndOpen(string fileName, string content)
    {
        string path = Path.Combine(FolderPath, fileName);
        File.WriteAllText(path, content);
        Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
    }

    public static void PrintDepositReceipt(User user, BankAccount acc, decimal amount)
    {
        string refNo = GenerateRef();
        string txt =
$@"ESTANOCO BANK
---------------------------------------
TRANSACTION RECEIPT - DEPOSIT
Reference #: {refNo}

Name: {user.Fullname}
Username: {user.Username}

Amount Deposited: ₱{amount:N2}
New Balance: ₱{acc.Balance:N2}
Date: {DateTime.Now}

Thank you for banking with us!
---------------------------------------";

        SaveAndOpen($"Deposit_{refNo}.txt", txt);
    }

    public static void PrintWithdrawReceipt(User user, BankAccount acc, decimal amount)
    {
        string refNo = GenerateRef();
        string txt =
$@"ESTANOCO BANK
---------------------------------------
TRANSACTION RECEIPT - WITHDRAWAL
Reference #: {refNo}

Name: {user.Fullname}
Username: {user.Username}

Amount Withdrawn: ₱{amount:N2}
New Balance: ₱{acc.Balance:N2}
Date: {DateTime.Now}

Thank you for banking with us!
---------------------------------------";

        SaveAndOpen($"Withdraw_{refNo}.txt", txt);
    }

    public static void PrintTransferReceipt(User sender, User receiver, BankAccount src, BankAccount dest, decimal amount)
    {
        string refNo = GenerateRef();
        string txt =
$@"MEEBank 
---------------------------------------
TRANSACTION RECEIPT - TRANSFER
Reference #: {refNo}

SENDER:
Name: {sender.Fullname}
Account ID: {src.Id}

RECEIVER:
Name: {receiver.Fullname}
Account ID: {dest.Id}

Amount Transferred: ₱{amount:N2}
Sender New Balance: ₱{src.Balance:N2}

Date: {DateTime.Now}
---------------------------------------
Thank you for banking with us!";

        SaveAndOpen($"Transfer_{refNo}.txt", txt);
    }
}
