using StudentManagementSystemApp;

StudentBL sBLobj  = new StudentBL();
sBLobj.AcceptStudentDetails();
// sBLobj.CalcTotal();
// sBLobj.CalcAvg();
int t1;
float p1;
sBLobj.CalcResult(out t1, out p1);


System.Console.WriteLine($"Total {sBLobj.CalcTotal()}" );
System.Console.WriteLine($"Percentage {sBLobj.CalcAvg()}" );