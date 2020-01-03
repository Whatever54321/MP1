/*
* MATLAB Compiler: 7.0 (R2018b)
* Date: Mon Oct 14 15:51:06 2019
* Arguments:
* "-B""macro_default""-W""dotnet:fmincon_r,f_method1,4.0,private""-T""link:lib""-d""C:\Use
* rs\xjs\Desktop\MP1\fmincon_r\for_testing""-v""class{f_method1:C:\Users\xjs\Desktop\matla
* b_related\fmincon_r.m}"
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace fmincon_rNative
{

  /// <summary>
  /// The f_method1 class provides a CLS compliant, Object (native) interface to the
  /// MATLAB functions contained in the files:
  /// <newpara></newpara>
  /// C:\Users\xjs\Desktop\matlab_related\fmincon_r.m
  /// </summary>
  /// <remarks>
  /// @Version 4.0
  /// </remarks>
  public class f_method1 : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static f_method1()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "fmincon_r.ctf";

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
    /// Constructs a new instance of the f_method1 class.
    /// </summary>
    public f_method1()
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
    ~f_method1()
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
    /// Provides a single output, 0-input Objectinterface to the fmincon_r MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// eval(['func1=@(',str2,')',str1,'-1;']);
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem);
    /// fval = func(result);
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fmincon_r()
    {
      return mcr.EvaluateFunction("fmincon_r", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the fmincon_r MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// eval(['func1=@(',str2,')',str1,'-1;']);
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem);
    /// fval = func(result);
    /// </remarks>
    /// <param name="str1">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fmincon_r(Object str1)
    {
      return mcr.EvaluateFunction("fmincon_r", str1);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the fmincon_r MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// eval(['func1=@(',str2,')',str1,'-1;']);
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem);
    /// fval = func(result);
    /// </remarks>
    /// <param name="str1">Input argument #1</param>
    /// <param name="str2">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fmincon_r(Object str1, Object str2)
    {
      return mcr.EvaluateFunction("fmincon_r", str1, str2);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the fmincon_r MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// eval(['func1=@(',str2,')',str1,'-1;']);
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem);
    /// fval = func(result);
    /// </remarks>
    /// <param name="str1">Input argument #1</param>
    /// <param name="str2">Input argument #2</param>
    /// <param name="x0">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fmincon_r(Object str1, Object str2, Object x0)
    {
      return mcr.EvaluateFunction("fmincon_r", str1, str2, x0);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the fmincon_r MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// eval(['func1=@(',str2,')',str1,'-1;']);
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem);
    /// fval = func(result);
    /// </remarks>
    /// <param name="str1">Input argument #1</param>
    /// <param name="str2">Input argument #2</param>
    /// <param name="x0">Input argument #3</param>
    /// <param name="lbvalue">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fmincon_r(Object str1, Object str2, Object x0, Object lbvalue)
    {
      return mcr.EvaluateFunction("fmincon_r", str1, str2, x0, lbvalue);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the fmincon_r MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// eval(['func1=@(',str2,')',str1,'-1;']);
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem);
    /// fval = func(result);
    /// </remarks>
    /// <param name="str1">Input argument #1</param>
    /// <param name="str2">Input argument #2</param>
    /// <param name="x0">Input argument #3</param>
    /// <param name="lbvalue">Input argument #4</param>
    /// <param name="ubvalue">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fmincon_r(Object str1, Object str2, Object x0, Object lbvalue, Object 
                      ubvalue)
    {
      return mcr.EvaluateFunction("fmincon_r", str1, str2, x0, lbvalue, ubvalue);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the fmincon_r MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// eval(['func1=@(',str2,')',str1,'-1;']);
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem);
    /// fval = func(result);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fmincon_r(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "fmincon_r", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the fmincon_r MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// eval(['func1=@(',str2,')',str1,'-1;']);
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem);
    /// fval = func(result);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="str1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fmincon_r(int numArgsOut, Object str1)
    {
      return mcr.EvaluateFunction(numArgsOut, "fmincon_r", str1);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the fmincon_r MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// eval(['func1=@(',str2,')',str1,'-1;']);
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem);
    /// fval = func(result);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="str1">Input argument #1</param>
    /// <param name="str2">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fmincon_r(int numArgsOut, Object str1, Object str2)
    {
      return mcr.EvaluateFunction(numArgsOut, "fmincon_r", str1, str2);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the fmincon_r MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// eval(['func1=@(',str2,')',str1,'-1;']);
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem);
    /// fval = func(result);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="str1">Input argument #1</param>
    /// <param name="str2">Input argument #2</param>
    /// <param name="x0">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fmincon_r(int numArgsOut, Object str1, Object str2, Object x0)
    {
      return mcr.EvaluateFunction(numArgsOut, "fmincon_r", str1, str2, x0);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the fmincon_r MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// eval(['func1=@(',str2,')',str1,'-1;']);
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem);
    /// fval = func(result);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="str1">Input argument #1</param>
    /// <param name="str2">Input argument #2</param>
    /// <param name="x0">Input argument #3</param>
    /// <param name="lbvalue">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fmincon_r(int numArgsOut, Object str1, Object str2, Object x0, Object 
                        lbvalue)
    {
      return mcr.EvaluateFunction(numArgsOut, "fmincon_r", str1, str2, x0, lbvalue);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the fmincon_r MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// eval(['func1=@(',str2,')',str1,'-1;']);
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem);
    /// fval = func(result);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="str1">Input argument #1</param>
    /// <param name="str2">Input argument #2</param>
    /// <param name="x0">Input argument #3</param>
    /// <param name="lbvalue">Input argument #4</param>
    /// <param name="ubvalue">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fmincon_r(int numArgsOut, Object str1, Object str2, Object x0, Object 
                        lbvalue, Object ubvalue)
    {
      return mcr.EvaluateFunction(numArgsOut, "fmincon_r", str1, str2, x0, lbvalue, ubvalue);
    }


    /// <summary>
    /// Provides an interface for the fmincon_r function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// eval(['func1=@(',str2,')',str1,'-1;']);
    /// options = optimoptions('particleswarm','display','off');
    /// x0 = particleswarm(@(x)sum(func(x).^2),n,lb,ub,options);
    /// opts = optimoptions(@fmincon,'Algorithm','interior-point','Display','off');
    /// problem  =
    /// createOptimProblem('fmincon','x0',x0,'objective',@(x)0,'lb',lb,'ub',ub,'nonlcon',@
    /// (x)constrain(x,func));
    /// gs = GlobalSearch;
    /// [result,~,exitflag] = gs.run(problem);
    /// fval = func(result);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("fmincon_r", 5, 2, 0)]
    protected void fmincon_r(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("fmincon_r", numArgsOut, ref argsOut, argsIn, varArgsIn);
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
