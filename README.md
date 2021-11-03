# MessagePack-iOS-sample
Sample of using messagepack in a xamarin iOS/android app (throws exception on iOS)

{System.NotImplementedException: byref delegate
  at System.Linq.Expressions.Interpreter.LightLambda.CreateCustomDelegate (System.Type delegateType) [0x001cf] in /Library/Frameworks/Xamarin.iOS.framework/Versions/Current/src/Xamarin.iOS/external/corefx/src/System.Linq.Expressions/src/System/Linq/Expressions/Interpreter/LightLambda.cs:422 
  at System.Linq.Expressions.Interpreter.LightLambda.MakeDelegate (System.Type delegateType) [0x00012] in /Library/Frameworks/Xamarin.iOS.framework/Versions/Current/src/Xamarin.iOS/external/corefx/src/System.Linq.Expressions/src/System/Linq/Expressions/Interpreter/LightLambda.cs:446 
  at System.Linq.Expressions.Interpreter.LightDelegateCreator.CreateDelegate (System.Runtime.CompilerServices.IStrongBox[] closure) [0x00000] in /Library/Frameworks/Xamarin.iOS.framework/Versions/Current/src/Xamarin.iOS/external/corefx/src/System.Linq.Expressions/src/System/Linq/Expressions/Interpreter/LightDelegateCreator.cs:33 
  at System.Linq.Expressions.Interpreter.LightDelegateCreator.CreateDelegate () [0x00000] in /Library/Frameworks/Xamarin.iOS.framework/Versions/Current/src/Xamarin.iOS/external/corefx/src/System.Linq.Expressions/src/System/Linq/Expressions/Interpreter/LightDelegateCreator.cs:28 
  at System.Linq.Expressions.Expression`1[TDelegate].Compile (System.Boolean preferInterpretation) [0x00000] in /Library/Frameworks/Xamarin.iOS.framework/Versions/Current/src/Xamarin.iOS/external/corefx/src/System.Linq.Expressions/src/System/Linq/Expressions/LambdaExpression.cs:211 
  at MessagePack.MessagePackSerializer+CompiledMethods..ctor (System.Type type) [0x0046d] in <e372d2478807460eabc86dc315aa3ac8>:0 
  at MessagePack.MessagePackSerializer+<>c.<.cctor>b__45_0 (System.Type t) [0x00000] in <e372d2478807460eabc86dc315aa3ac8>:0 
  at MessagePack.Internal.ThreadsafeTypeKeyHashTable`1[TValue].AddToBuckets (MessagePack.Internal.ThreadsafeTypeKeyHashTable`1+Entry[TValue][] buckets, System.Type newKey, MessagePack.Internal.ThreadsafeTypeKeyHashTable`1+Entry[TValue] newEntryOrNull, System.Func`2[T,TResult] valueFactory, TValue& resultingValue) [0x00045] in <e372d2478807460eabc86dc315aa3ac8>:0 
  at MessagePack.Internal.ThreadsafeTypeKeyHashTable`1[TValue].TryAddInternal (System.Type key, System.Func`2[T,TResult] valueFactory, TValue& resultingValue) [0x000d2] in <e372d2478807460eabc86dc315aa3ac8>:0 
  at MessagePack.Internal.ThreadsafeTypeKeyHashTable`1[TValue].GetOrAdd (System.Type key, System.Func`2[T,TResult] valueFactory) [0x0000d] in <e372d2478807460eabc86dc315aa3ac8>:0 
  at MessagePack.MessagePackSerializer.GetOrAdd (System.Type type) [0x00000] in <e372d2478807460eabc86dc315aa3ac8>:0 
  at MessagePack.MessagePackSerializer.Deserialize (System.Type type, System.ReadOnlyMemory`1[T] bytes, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken) [0x00000] in <e372d2478807460eabc86dc315aa3ac8>:0 
  at MessagePackSample.MainPage.OnAppearing () [0x000f5] in C:\Projects\MessagePack-iOS-sample\MessagePackSample\MessagePackSample\MessagePackSample\MainPage.xaml.cs:54 }
