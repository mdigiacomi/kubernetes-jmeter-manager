using System;

namespace JMeter_Manager.Models
{
    public class JMSMessage
    {
        public static string RequestId = @"<?xml version=""1.0"" encoding=""UTF-8""?>
<jmeterTestPlan version=""1.2"" properties=""5.0"" jmeter=""5.0 r1840935"">
  <hashTree>
    <TestPlan guiclass=""TestPlanGui"" testclass=""TestPlan"" testname=""Test Plan"" enabled=""true"">
      <stringProp name=""TestPlan.comments""></stringProp>
      <boolProp name=""TestPlan.functional_mode"">false</boolProp>
      <boolProp name=""TestPlan.tearDown_on_shutdown"">true</boolProp>
      <boolProp name=""TestPlan.serialize_threadgroups"">false</boolProp>
      <elementProp name=""TestPlan.user_defined_variables"" elementType=""Arguments"" guiclass=""ArgumentsPanel"" testclass=""Arguments"" testname=""User Defined Variables"" enabled=""true"">
        <collectionProp name=""Arguments.arguments"">
          <elementProp name=""Team"" elementType=""Argument"">
            <stringProp name=""Argument.name"">Team</stringProp>
            <stringProp name=""Argument.value"">DevOps</stringProp>
            <stringProp name=""Argument.metadata"">=</stringProp>
          </elementProp>
          <elementProp name=""Application"" elementType=""Argument"">
            <stringProp name=""Argument.name"">Application</stringProp>
            <stringProp name=""Argument.value"">DevOps-Testing</stringProp>
            <stringProp name=""Argument.metadata"">=</stringProp>
          </elementProp>
        </collectionProp>
      </elementProp>
      <stringProp name=""TestPlan.user_define_classpath""></stringProp>
    </TestPlan>
    <hashTree>
      <ThreadGroup guiclass=""ThreadGroupGui"" testclass=""ThreadGroup"" testname=""Thread Group"" enabled=""true"">
        <stringProp name=""ThreadGroup.on_sample_error"">continue</stringProp>
        <elementProp name=""ThreadGroup.main_controller"" elementType=""LoopController"" guiclass=""LoopControlPanel"" testclass=""LoopController"" testname=""Loop Controller"" enabled=""true"">
          <boolProp name=""LoopController.continue_forever"">false</boolProp>
          <intProp name=""LoopController.loops"">-1</intProp>
        </elementProp>
        <stringProp name=""ThreadGroup.num_threads"">50</stringProp>
        <stringProp name=""ThreadGroup.ramp_time"">1</stringProp>
        <boolProp name=""ThreadGroup.scheduler"">true</boolProp>
        <stringProp name=""ThreadGroup.duration"">60</stringProp>
        <stringProp name=""ThreadGroup.delay""></stringProp>
      </ThreadGroup>
      <hashTree>
        <HTTPSamplerProxy guiclass=""HttpTestSampleGui"" testclass=""HTTPSamplerProxy"" testname=""HTTP Request"" enabled=""true"">
          <boolProp name=""HTTPSampler.postBodyRaw"">true</boolProp>
          <elementProp name=""HTTPsampler.Arguments"" elementType=""Arguments"">
            <collectionProp name=""Arguments.arguments"">
              <elementProp name="""" elementType=""HTTPArgument"">
                <boolProp name=""HTTPArgument.always_encode"">false</boolProp>
                <stringProp name=""Argument.value"">&lt;%https://raw.githubusercontent.com/corysimmons/colors.json/master/colors.json%&gt;</stringProp>
                <stringProp name=""Argument.metadata"">=</stringProp>
              </elementProp>
            </collectionProp>
          </elementProp>
          <stringProp name=""HTTPSampler.domain"">foreveryounghairstudio.com</stringProp>
          <stringProp name=""HTTPSampler.port""></stringProp>
          <stringProp name=""HTTPSampler.protocol"">http</stringProp>
          <stringProp name=""HTTPSampler.contentEncoding""></stringProp>
          <stringProp name=""HTTPSampler.path""></stringProp>
          <stringProp name=""HTTPSampler.method"">GET</stringProp>
          <boolProp name=""HTTPSampler.follow_redirects"">true</boolProp>
          <boolProp name=""HTTPSampler.auto_redirects"">false</boolProp>
          <boolProp name=""HTTPSampler.use_keepalive"">true</boolProp>
          <boolProp name=""HTTPSampler.DO_MULTIPART_POST"">false</boolProp>
          <stringProp name=""HTTPSampler.embedded_url_re""></stringProp>
          <stringProp name=""HTTPSampler.connect_timeout""></stringProp>
          <stringProp name=""HTTPSampler.response_timeout""></stringProp>
        </HTTPSamplerProxy>
        <hashTree/>
      </hashTree>
    </hashTree>
  </hashTree>
</jmeterTestPlan>
";

    }
}