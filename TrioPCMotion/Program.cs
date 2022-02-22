using System;
using TrioMotion.TrioPC_NET;

namespace TrioPCMotion
{
    internal class Program
    {
        private const short axis0 = 0, axis1 = 1, axis2 = 2, axis3 = 3;
        static void Main(string[] args)
        {
            // Create an instance of MyController
            MyController myController = new MyController();
            myController.ConnectToController("127.0.0.1");

            #region test_code
            #endregion


            Console.ReadLine();
        }
    }
    internal class MyController : TrioPC
    {
        internal void ConnectToController(string ip_address)
        {
            this.SetHost(ip_address);

            if (this.Open(PortType.Ethernet, PortId.EthernetREMOTE))
            {
                Console.WriteLine("Connected to contoller on ip: {0}", this.HostAddress);
                Console.WriteLine("===============================================");
            }
            else
            {
                Console.WriteLine("Error in connecting to ip: {0}", this.HostAddress);
            }
        }

        
    }
}

#region moves
//double[] myAxes = { axis0, axis1, axis2, axis3 };
//myController.Base(myAxes.Length, myAxes);

//// Set current position as 0 for each axis
//myController.Defpos(0, axis0);
//myController.Defpos(0, axis1);
//myController.Defpos(0, axis2);
//myController.Defpos(0, axis3);

//// Set axis parameters of the base array
//myController.SetAxisVariable("SPEED", axis0, 10);
//myController.SetAxisVariable("SPEED", axis1, 10);
//myController.SetAxisVariable("SPEED", axis2, 10);
//myController.SetAxisVariable("SPEED", axis3, 10);

//myController.SetAxisVariable("ACCEL", axis0, 100);
//myController.SetAxisVariable("ACCEL", axis1, 100);
//myController.SetAxisVariable("ACCEL", axis2, 100);
//myController.SetAxisVariable("ACCEL", axis3, 100);

//myController.SetAxisVariable("DECEL", axis0, 100);
//myController.SetAxisVariable("DECEL", axis1, 100);
//myController.SetAxisVariable("DECEL", axis2, 100);
//myController.SetAxisVariable("DECEL", axis3, 100);

//// Set of moves
//double[] distance = { 50, 70, 10, 20 };
//myController.MoveAbs(distance, 2, axis0);
//myController.MoveRel(distance, 2, axis0);
//myController.MoveCirc(30, 30, 30, 0, 1);
#endregion

#region CANCEL
////  Set axis 2 parameters
//myController.SetAxisVariable("UNITS", 2, 1.0); // Set axis 2 units to 1
//myController.SetAxisVariable("SPEED", 2, 10.0); // Set axis 2 speed to 10 units per sec
//myController.SetAxisVariable("ACCEL", 2, 100.0); // Set axis 2 acceleration rate to 100 units per sec*sec
//myController.SetAxisVariable("DECEL", 2, 100.0); // Set axis 2 deceleration rate to 100 units per sec*sec
//myController.Forward(2); // Run axis 0

//while (true)
//{
//    double in_0_7_val;
//    if (myController.In(0, 0, out in_0_7_val))
//    {
//        if (in_0_7_val == 1) myController.Cancel(0, 2); // Stop move in MTYPE for axis 2
//    }
//    else Console.WriteLine("Error in getting input 0");
//}
#endregion

#region FORWARD RAPIDSTOP
////  Set axis 2 parameters
//myController.SetAxisVariable("UNITS", 2, 1.0); // Set axis 2 units to 1
//myController.SetAxisVariable("SPEED", 2, 10.0); // Set axis 2 speed to 10 units per sec
//myController.SetAxisVariable("ACCEL", 2, 100.0); // Set axis 2 acceleration rate to 100 units per sec*sec
//myController.SetAxisVariable("DECEL", 2, 100.0); // Set axis 2 deceleration rate to 100 units per sec*sec
//myController.Forward(2); // Run axis 0

//while (true)
//{
//    double in_0_7_val;
//    if (myController.In(0, 0, out in_0_7_val))
//    {
//        if (in_0_7_val == 1) myController.RapidStop(); // Stop all move
//    }
//    else Console.WriteLine("Error in getting input 0");
//}
#endregion

#region GetDI()
// ============================ Inside Main() =========================================
//string progname = "test_move";
//short old_di_value = 0;
//bool prog_run_state = false;

//while (true)
//{
//    short temp_val = myController.GetDI(0);
//    if (temp_val != old_di_value)
//    {
//        old_di_value = temp_val; // Store rising/falling edge of IN(0)

//        if ((temp_val == 1) && (prog_run_state == false))
//        {
//            myController.Run(progname, 10);

//            prog_run_state = true; // Update running flag

//            Console.WriteLine("{0}: Running", progname);
//        }

//        if ((temp_val == 0) && (prog_run_state == true))
//        {
//            myController.Stop(progname);

//            Console.WriteLine("{0}: Stopped", progname);
//        }
//    }
//}
// ===================================== END ==========================================

// ============================ Inside class MyController =============================
//// Get specific digital input. 1 = ON; 0 = OFF; -1 = error 
//internal short GetDI(int di_number)
//{
//    if (this.IsOpen(PortId.EthernetREMOTE))
//    {
//        double input_val;
//        if (this.In(di_number, di_number, out input_val))
//        {
//            return Convert.ToInt16(input_val);
//        }
//        else
//        {
//            Console.WriteLine("Failed to retrieve input value");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Failed connection to controller on address: {0}", this.HostAddress);
//    }

//    return -1;
//}
// ===================================== END ==========================================
#endregion

#region GetVariable()
// ============================ Inside Main() =========================================
//double result;
//myController.GetVariable("ATYPE", out result);
//Console.WriteLine("ATYPE = {0}", result);
// ===================================== END ==========================================
#endregion

#region Directory
// ============================ Inside Main() =========================================
//// Print directory information
//string dir_output;
//if (myController.IsOpen(PortId.EthernetREMOTE))
//{
//    myController.Dir(out dir_output);
//    Console.WriteLine(dir_output);
//}
// ===================================== END ==========================================
#endregion

#region connection
// ============================ Inside Main() =========================================
//// Create an instance of MyController
//MyController myController = new MyController();
//myController.ConnectToController(args[0]);
// ===================================== END ==========================================

// ============================ Inside class MyController =============================
//internal void ConnectToController(string ip_address)
//{
//    this.SetHost(ip_address);

//    if (this.Open(PortType.Ethernet, PortId.EthernetREMOTE))
//    {
//        Console.WriteLine("Connected to contoller on ip: {0}", this.HostAddress);
//        Console.WriteLine("===============================================");
//    }
//    else
//    {
//        Console.WriteLine("Error in connecting to ip: {0}", this.HostAddress);
//    }
//}
// ===================================== END ==========================================
#endregion

#region MoveRel
// ============================ Inside Main() =========================================
//// Set axes order via BASE cmd
//double[] axes_order = { 0, 2, 5 };
//myController.Base(axes_order.Length, axes_order);

//// Print MPOS for each axis before and after move
//double temp;
//Console.WriteLine("Before move:");
//foreach (double axis in axes_order)
//{
//    myController.GetAxisVariable("MPOS", (int)axis, out temp);
//    Console.WriteLine(temp);
//}

//// Move axes
//double[] axes_move_distance = { 10, 20, 30 };
//myController.MoveRel(axes_move_distance);

//Console.WriteLine("After move:");
//foreach (double axis in axes_order)
//{
//    myController.GetAxisVariable("MPOS", (int)axis, out temp);
//    Console.WriteLine(temp);
//}
// ===================================== END ==========================================
#endregion

#region DefPos
// ============================ Inside Main() =========================================
//// Set axes order via BASE cmd
//double[] axes_order = { 0, 2, 5 };
//myController.Base(axes_order.Length, axes_order);

//double temp;
//Console.WriteLine("Before defpos:");
//foreach (double axis in axes_order)
//{
//    myController.GetAxisVariable("MPOS", (int)axis, out temp);
//    Console.WriteLine(temp);
//}

////Set current positions as zero
//foreach (double axis in axes_order)
//{
//    myController.Defpos(0, (int)axis);
//}

//Console.WriteLine("After defpos:");
//foreach (double axis in axes_order)
//{
//    myController.GetAxisVariable("MPOS", (int)axis, out temp);
//    Console.WriteLine(temp);
//}
// ===================================== END ==========================================
#endregion

#region MoveAbs
// ============================ Inside Main() =========================================
//// Set axes order via BASE cmd
//double[] axes_order = { 0, 2, 5 };
//myController.Base(axes_order.Length, axes_order);

//// Print MPOS for each axis before and after move
//double temp;
//Console.WriteLine("Before move:");
//foreach (double axis in axes_order)
//{
//    myController.GetAxisVariable("MPOS", (int)axis, out temp);
//    Console.WriteLine(temp);
//}

//// Move axes
//double[] axes_move_destination = { 100, 200, 300 };
//myController.MoveAbs(axes_move_destination);

//Console.WriteLine("After move:");
//foreach (double axis in axes_order)
//{
//    myController.GetAxisVariable("MPOS", (int)axis, out temp);
//    Console.WriteLine(temp);
//}
// ===================================== END ==========================================
#endregion

#region SetTable
// ============================ Inside Main() =========================================
//double[] valArray = { 1.2, 2.3, 3.4, 4.5, 5.6, 6.7 };
//myController.SetTable(0, valArray);
//myController.SetTable(10, 5, valArray);
//myController.SetTable(20, valArray, 2, 4);
// ===================================== END ==========================================
#endregion

#region DisplayTableValues
// ============================ Inside Main() =========================================
//myController.DisplayTableValues(10);
// ===================================== END ==========================================

// ============================ Inside class MyController =============================
//internal void DisplayTableValues(int startingIndex)
//{
//    double[] temp = new double[1000];

//    if (this.IsOpen(PortId.EthernetREMOTE))
//    {
//        if (this.GetTable(startingIndex, ref temp))
//        {
//            for (int i = 0; i < temp.Length; i++)
//            {
//                Console.WriteLine("TABLE({0}) = {1}", (i + startingIndex), temp[i]);
//            }
//        }
//    }
//    else
//    {
//        Console.WriteLine("Not connected to controller");
//    }
//}
// ===================================== END ==========================================
#endregion

#region DisplayTableValues(,)
// ============================ Inside Main() =========================================
//myController.DisplayTableValues(10, 5);
// ===================================== END ==========================================

// ============================ Inside class MyController =============================
//internal void DisplayTableValues(int startingIndex, int number)
//{
//    double[] temp = new double[number];

//    if (this.IsOpen(PortId.EthernetREMOTE))
//    {
//        if (this.GetTable(startingIndex, number, ref temp))
//        {
//            for (int i = 0; i < number; i++)
//            {
//                Console.WriteLine("TABLE({0}) = {1}", (i + startingIndex), temp[i]);
//            }
//        }
//    }
//    else
//    {
//        Console.WriteLine("Not connected to controller");
//    }
//}
// ===================================== END ==========================================
#endregion

#region DisplayTableValues(,,)
// ============================ Inside Main() =========================================
//myController.DisplayTableValues(10, 5, 1);
// ===================================== END ==========================================

// ============================ Inside class MyController =============================
//internal void DisplayTableValues(int startingIndex, int number, int offset)
//{
//    double[] temp = new double[number];

//    if (this.IsOpen(PortId.EthernetREMOTE))
//    {
//        if (this.GetTable(startingIndex, number, offset, ref temp))
//        {
//            for (int i = 0; i < number; i++)
//            {
//                Console.WriteLine("TABLE({0}) = {1}", (i + startingIndex + (i * offset)), temp[i]);
//            }
//        }
//    }
//    else
//    {
//        Console.WriteLine("Not connected to controller");
//    }
//}
// ===================================== END ==========================================
#endregion

#region DisplayAxisParameter()
// ============================ Inside Main() =========================================
//myController.DisplayAxisParameter("units", 1);
// ===================================== END ==========================================

// ============================ Inside class MyController =============================
//internal void DisplayAxisParameter(string axisParameter, int axisNo)
//{
//    double temp;

//    if (this.IsOpen(PortId.EthernetREMOTE))
//    {
//        if (this.GetAxisVariable(axisParameter.ToUpper(), axisNo, out temp))
//        {
//            Console.WriteLine("Axis {0} {1} = {2}", axisNo, axisParameter.ToUpper(), temp);
//        }
//        else
//        {
//            Console.WriteLine("Invalid axis parameter name");
//        }

//    }
//    else
//    {
//        Console.WriteLine("Not connected to controller");
//    }
//}
// ===================================== END ==========================================
#endregion

#region In()
// ============================ Inside Main() =========================================
//double binarySum;
//int startIndex = 0, endIndex = 15;

//myController.In(startIndex, endIndex, out binarySum);
//Console.WriteLine("Binary sum input value = {0}", binarySum);
// ===================================== END ==========================================
#endregion

#region SetVr()
// ============================ Inside class MyController =============================
//internal void tripleVRs(int startingIndex, int number)
//{
//    double temp;

//    Console.WriteLine("Initialising VRs to tripple the original values ...");

//    if (this.IsOpen(PortId.EthernetREMOTE))
//    {
//        for (int index = 0; index < number; index++)
//        {
//            this.GetVr((index + startingIndex), out temp);

//            temp = 3 * temp;

//            this.SetVr((index + startingIndex), temp);
//        }
//    }
//    else
//    {
//        Console.WriteLine("Not connected to controller");
//    }
//}
// ===================================== END ==========================================
#endregion

#region DisplayVRs()
// ============================ Inside Main() =========================================
//// Get initial VR index to display
//Console.WriteLine("Enter VR start index: ");
//int startVR = Convert.ToInt32(Console.ReadLine());

//// Get total VR index to display
//Console.WriteLine("Enter total VRs to fetch");
//int totalVR = Convert.ToInt32(Console.ReadLine());

//myController.DisplayVRs(startVR, totalVR);
// ===================================== END ==========================================


// ============================ Inside class MyController =============================
//internal void DisplayVRs(int startingIndex, int number)
//{
//    double temp;

//    Console.WriteLine("Reading VRs:");

//    if (this.IsOpen(PortId.EthernetREMOTE))
//    {
//        for (int index = 0; index < number; index++)
//        {
//            if (this.GetVr((index + startingIndex), out temp))
//            {
//                Console.WriteLine("VR({0}) = {1}", (index + startingIndex), temp);
//            }
//        }
//    }
//    else
//    {
//        Console.WriteLine("Not connected to controller");
//    }
//}
// ===================================== END ==========================================
#endregion

#region SetAxisVariable()
// ============================ Inside Main() =========================================
//myController.SetAxisVariable("units", 1, 1000);
// ===================================== END ==========================================

// ============================ Inside class MyController =============================
//public new void SetAxisVariable(string axisParameter, int axisNo, double value)
//{
//    if (this.IsOpen(PortId.EthernetREMOTE))
//    {
//        if (base.SetAxisVariable(axisParameter.ToUpper(), axisNo, value))
//        {
//            Console.WriteLine("Setting axis {0} parameter - {1} = {2}", axisNo, axisParameter, value);
//        }
//        else
//        {
//            Console.WriteLine("Invalid axis parameter name");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Not connected to controller");
//    }
//}
// ===================================== END ==========================================
#endregion
