/*
* MATLAB Compiler: 7.0 (R2018b)
* Date: Mon Oct 14 15:48:39 2019
* Arguments:
* "-B""macro_default""-W""dotnet:fsolve_r1,f_method,4.0,private""-T""link:lib""-d""C:\User
* s\xjs\Desktop\MP1\fsolve_r1\for_testing""-v""class{f_method:C:\Users\xjs\Desktop\matlab_
* related\fsolve_r1.m}"
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace fsolve_r1Native
{

  /// <summary>
  /// The f_method class provides a CLS compliant, Object (native) interface to the
  /// MATLAB functions contained in the files:
  /// <newpara></newpara>
  /// C:\Users\xjs\Desktop\matlab_related\fsolve_r1.m
  /// </summary>
  /// <remarks>
  /// @Version 4.0
  /// </remarks>
  public class f_method : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static f_method()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "fsolve_r1.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the f_method class.
    /// </summary>
    public f_method()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~f_method()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the fsolve_r1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem,start_num);
    /// fval = func(result);
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fsolve_r1()
    {
      return mcr.EvaluateFunction("fsolve_r1", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the fsolve_r1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem,start_num);
    /// fval = func(result);
    /// </remarks>
    /// <param name="str1">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fsolve_r1(Object str1)
    {
      return mcr.EvaluateFunction("fsolve_r1", str1);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the fsolve_r1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem,start_num);
    /// fval = func(result);
    /// </remarks>
    /// <param name="str1">Input argument #1</param>
    /// <param name="str2">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fsolve_r1(Object str1, Object str2)
    {
      return mcr.EvaluateFunction("fsolve_r1", str1, str2);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the fsolve_r1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem,start_num);
    /// fval = func(result);
    /// </remarks>
    /// <param name="str1">Input argument #1</param>
    /// <param name="str2">Input argument #2</param>
    /// <param name="n">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fsolve_r1(Object str1, Object str2, Object n)
    {
      return mcr.EvaluateFunction("fsolve_r1", str1, str2, n);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the fsolve_r1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem,start_num);
    /// fval = func(result);
    /// </remarks>
    /// <param name="str1">Input argument #1</param>
    /// <param name="str2">Input argument #2</param>
    /// <param name="n">Input argument #3</param>
    /// <param name="lb">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fsolve_r1(Object str1, Object str2, Object n, Object lb)
    {
      return mcr.EvaluateFunction("fsolve_r1", str1, str2, n, lb);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the fsolve_r1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem,start_num);
    /// fval = func(result);
    /// </remarks>
    /// <param name="str1">Input argument #1</param>
    /// <param name="str2">Input argument #2</param>
    /// <param name="n">Input argument #3</param>
    /// <param name="lb">Input argument #4</param>
    /// <param name="ub">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fsolve_r1(Object str1, Object str2, Object n, Object lb, Object ub)
    {
      return mcr.EvaluateFunction("fsolve_r1", str1, str2, n, lb, ub);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the fsolve_r1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem,start_num);
    /// fval = func(result);
    /// </remarks>
    /// <param name="str1">Input argument #1</param>
    /// <param name="str2">Input argument #2</param>
    /// <param name="n">Input argument #3</param>
    /// <param name="lb">Input argument #4</param>
    /// <param name="ub">Input argument #5</param>
    /// <param name="start_num">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fsolve_r1(Object str1, Object str2, Object n, Object lb, Object ub, 
                      Object start_num)
    {
      return mcr.EvaluateFunction("fsolve_r1", str1, str2, n, lb, ub, start_num);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the fsolve_r1 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem,start_num);
    /// fval = func(result);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fsolve_r1(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "fsolve_r1", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the fsolve_r1 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem,start_num);
    /// fval = func(result);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="str1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fsolve_r1(int numArgsOut, Object str1)
    {
      return mcr.EvaluateFunction(numArgsOut, "fsolve_r1", str1);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the fsolve_r1 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem,start_num);
    /// fval = func(result);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="str1">Input argument #1</param>
    /// <param name="str2">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fsolve_r1(int numArgsOut, Object str1, Object str2)
    {
      return mcr.EvaluateFunction(numArgsOut, "fsolve_r1", str1, str2);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the fsolve_r1 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem,start_num);
    /// fval = func(result);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="str1">Input argument #1</param>
    /// <param name="str2">Input argument #2</param>
    /// <param name="n">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fsolve_r1(int numArgsOut, Object str1, Object str2, Object n)
    {
      return mcr.EvaluateFunction(numArgsOut, "fsolve_r1", str1, str2, n);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the fsolve_r1 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem,start_num);
    /// fval = func(result);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="str1">Input argument #1</param>
    /// <param name="str2">Input argument #2</param>
    /// <param name="n">Input argument #3</param>
    /// <param name="lb">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fsolve_r1(int numArgsOut, Object str1, Object str2, Object n, Object 
                        lb)
    {
      return mcr.EvaluateFunction(numArgsOut, "fsolve_r1", str1, str2, n, lb);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the fsolve_r1 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem,start_num);
    /// fval = func(result);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="str1">Input argument #1</param>
    /// <param name="str2">Input argument #2</param>
    /// <param name="n">Input argument #3</param>
    /// <param name="lb">Input argument #4</param>
    /// <param name="ub">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fsolve_r1(int numArgsOut, Object str1, Object str2, Object n, Object 
                        lb, Object ub)
    {
      return mcr.EvaluateFunction(numArgsOut, "fsolve_r1", str1, str2, n, lb, ub);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the fsolve_r1 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem,start_num);
    /// fval = func(result);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="str1">Input argument #1</param>
    /// <param name="str2">Input argument #2</param>
    /// <param name="n">Input argument #3</param>
    /// <param name="lb">Input argument #4</param>
    /// <param name="ub">Input argument #5</param>
    /// <param name="start_num">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fsolve_r1(int numArgsOut, Object str1, Object str2, Object n, Object 
                        lb, Object ub, Object start_num)
    {
      return mcr.EvaluateFunction(numArgsOut, "fsolve_r1", str1, str2, n, lb, ub, start_num);
    }


    /// <summary>
    /// Provides an interface for the fsolve_r1 function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem,start_num);
    /// fval = func(result);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("fsolve_r1", 6, 3, 0)]
    protected void fsolve_r1(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("fsolve_r1", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }

    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
