﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

// <auto-generated>

using System.Collections.Generic;
using Roslynator.CSharp;

namespace Roslynator.VisualStudio
{
    public partial class GlobalSuppressionsOptionsPage
    {
        protected override string MaxId
        {
            get;
        }

        = "RCS1245";
        protected override void Fill(ICollection<BaseModel> analyzers)
        {
            analyzers.Clear();
            analyzers.Add(new BaseModel("RCS1001", "Add braces (when expression spans over multiple lines).", !IsEnabled("RCS1001")));
            analyzers.Add(new BaseModel("RCS1002", "Remove braces.", !IsEnabled("RCS1002")));
            analyzers.Add(new BaseModel("RCS1003", "Add braces to if-else (when expression spans over multiple lines).", !IsEnabled("RCS1003")));
            analyzers.Add(new BaseModel("RCS1004", "Remove braces from if-else.", !IsEnabled("RCS1004")));
            analyzers.Add(new BaseModel("RCS1005", "Simplify nested using statement.", !IsEnabled("RCS1005")));
            analyzers.Add(new BaseModel("RCS1006", "Merge else clause with nested if statement.", !IsEnabled("RCS1006")));
            analyzers.Add(new BaseModel("RCS1007", "Add braces.", !IsEnabled("RCS1007")));
            analyzers.Add(new BaseModel("RCS1008", "Use explicit type instead of 'var' (when the type is not obvious).", !IsEnabled("RCS1008")));
            analyzers.Add(new BaseModel("RCS1009", "Use explicit type instead of 'var' (foreach variable).", !IsEnabled("RCS1009")));
            analyzers.Add(new BaseModel("RCS1010", "Use 'var' instead of explicit type (when the type is obvious).", !IsEnabled("RCS1010")));
            analyzers.Add(new BaseModel("RCS1012", "Use explicit type instead of 'var' (when the type is obvious).", !IsEnabled("RCS1012")));
            analyzers.Add(new BaseModel("RCS1013", "Use predefined type.", !IsEnabled("RCS1013")));
            analyzers.Add(new BaseModel("RCS1014", "Avoid implicitly-typed array.", !IsEnabled("RCS1014")));
            analyzers.Add(new BaseModel("RCS1015", "Use nameof operator.", !IsEnabled("RCS1015")));
            analyzers.Add(new BaseModel("RCS1016", "Use expression-bodied member.", !IsEnabled("RCS1016")));
            analyzers.Add(new BaseModel("RCS1017", "Avoid multiline expression body.", !IsEnabled("RCS1017")));
            analyzers.Add(new BaseModel("RCS1018", "Add default access modifier.", !IsEnabled("RCS1018")));
            analyzers.Add(new BaseModel("RCS1019", "Order modifiers.", !IsEnabled("RCS1019")));
            analyzers.Add(new BaseModel("RCS1020", "Simplify Nullable<T> to T?.", !IsEnabled("RCS1020")));
            analyzers.Add(new BaseModel("RCS1021", "Simplify lambda expression.", !IsEnabled("RCS1021")));
            analyzers.Add(new BaseModel("RCS1023", "Format empty block.", !IsEnabled("RCS1023")));
            analyzers.Add(new BaseModel("RCS1024", "Format accessor list.", !IsEnabled("RCS1024")));
            analyzers.Add(new BaseModel("RCS1025", "Add new line before enum member.", !IsEnabled("RCS1025")));
            analyzers.Add(new BaseModel("RCS1026", "Add new line before statement.", !IsEnabled("RCS1026")));
            analyzers.Add(new BaseModel("RCS1027", "Add new line before embedded statement.", !IsEnabled("RCS1027")));
            analyzers.Add(new BaseModel("RCS1028", "Add new line after switch label.", !IsEnabled("RCS1028")));
            analyzers.Add(new BaseModel("RCS1029", "Format binary operator on next line.", !IsEnabled("RCS1029")));
            analyzers.Add(new BaseModel("RCS1030", "Add empty line after embedded statement.", !IsEnabled("RCS1030")));
            analyzers.Add(new BaseModel("RCS1032", "Remove redundant parentheses.", !IsEnabled("RCS1032")));
            analyzers.Add(new BaseModel("RCS1033", "Remove redundant boolean literal.", !IsEnabled("RCS1033")));
            analyzers.Add(new BaseModel("RCS1034", "Remove redundant 'sealed' modifier.", !IsEnabled("RCS1034")));
            analyzers.Add(new BaseModel("RCS1035", "Remove redundant comma in initializer.", !IsEnabled("RCS1035")));
            analyzers.Add(new BaseModel("RCS1036", "Remove redundant empty line.", !IsEnabled("RCS1036")));
            analyzers.Add(new BaseModel("RCS1037", "Remove trailing white-space.", !IsEnabled("RCS1037")));
            analyzers.Add(new BaseModel("RCS1038", "Remove empty statement.", !IsEnabled("RCS1038")));
            analyzers.Add(new BaseModel("RCS1039", "Remove argument list from attribute.", !IsEnabled("RCS1039")));
            analyzers.Add(new BaseModel("RCS1040", "Remove empty else clause.", !IsEnabled("RCS1040")));
            analyzers.Add(new BaseModel("RCS1041", "Remove empty initializer.", !IsEnabled("RCS1041")));
            analyzers.Add(new BaseModel("RCS1042", "Remove enum default underlying type.", !IsEnabled("RCS1042")));
            analyzers.Add(new BaseModel("RCS1043", "Remove 'partial' modifier from type with a single part.", !IsEnabled("RCS1043")));
            analyzers.Add(new BaseModel("RCS1044", "Remove original exception from throw statement.", !IsEnabled("RCS1044")));
            analyzers.Add(new BaseModel("RCS1045", "Rename private field according to camel case with underscore.", !IsEnabled("RCS1045")));
            analyzers.Add(new BaseModel("RCS1046", "Asynchronous method name should end with 'Async'.", !IsEnabled("RCS1046")));
            analyzers.Add(new BaseModel("RCS1047", "Non-asynchronous method name should not end with 'Async'.", !IsEnabled("RCS1047")));
            analyzers.Add(new BaseModel("RCS1048", "Use lambda expression instead of anonymous method.", !IsEnabled("RCS1048")));
            analyzers.Add(new BaseModel("RCS1049", "Simplify boolean comparison.", !IsEnabled("RCS1049")));
            analyzers.Add(new BaseModel("RCS1050", "Add argument list to object creation expression.", !IsEnabled("RCS1050")));
            analyzers.Add(new BaseModel("RCS1051", "Parenthesize condition in conditional expression.", !IsEnabled("RCS1051")));
            analyzers.Add(new BaseModel("RCS1052", "Declare each attribute separately.", !IsEnabled("RCS1052")));
            analyzers.Add(new BaseModel("RCS1055", "Avoid semicolon at the end of declaration.", !IsEnabled("RCS1055")));
            analyzers.Add(new BaseModel("RCS1056", "Avoid usage of using alias directive.", !IsEnabled("RCS1056")));
            analyzers.Add(new BaseModel("RCS1057", "Add empty line between declarations.", !IsEnabled("RCS1057")));
            analyzers.Add(new BaseModel("RCS1058", "Use compound assignment.", !IsEnabled("RCS1058")));
            analyzers.Add(new BaseModel("RCS1059", "Avoid locking on publicly accessible instance.", !IsEnabled("RCS1059")));
            analyzers.Add(new BaseModel("RCS1060", "Declare each type in separate file.", !IsEnabled("RCS1060")));
            analyzers.Add(new BaseModel("RCS1061", "Merge if statement with nested if statement.", !IsEnabled("RCS1061")));
            analyzers.Add(new BaseModel("RCS1062", "Avoid interpolated string with no interpolation.", !IsEnabled("RCS1062")));
            analyzers.Add(new BaseModel("RCS1063", "Avoid usage of do statement to create an infinite loop.", !IsEnabled("RCS1063")));
            analyzers.Add(new BaseModel("RCS1064", "Avoid usage of for statement to create an infinite loop.", !IsEnabled("RCS1064")));
            analyzers.Add(new BaseModel("RCS1065", "Avoid usage of while statement to create an inifinite loop.", !IsEnabled("RCS1065")));
            analyzers.Add(new BaseModel("RCS1066", "Remove empty finally clause.", !IsEnabled("RCS1066")));
            analyzers.Add(new BaseModel("RCS1067", "Remove argument list from object creation expression.", !IsEnabled("RCS1067")));
            analyzers.Add(new BaseModel("RCS1068", "Simplify logical negation.", !IsEnabled("RCS1068")));
            analyzers.Add(new BaseModel("RCS1069", "Remove unnecessary case label.", !IsEnabled("RCS1069")));
            analyzers.Add(new BaseModel("RCS1070", "Remove redundant default switch section.", !IsEnabled("RCS1070")));
            analyzers.Add(new BaseModel("RCS1071", "Remove redundant base constructor call.", !IsEnabled("RCS1071")));
            analyzers.Add(new BaseModel("RCS1072", "Remove empty namespace declaration.", !IsEnabled("RCS1072")));
            analyzers.Add(new BaseModel("RCS1073", "Replace if statement with return statement.", !IsEnabled("RCS1073")));
            analyzers.Add(new BaseModel("RCS1074", "Remove redundant constructor.", !IsEnabled("RCS1074")));
            analyzers.Add(new BaseModel("RCS1075", "Avoid empty catch clause that catches System.Exception.", !IsEnabled("RCS1075")));
            analyzers.Add(new BaseModel("RCS1076", "Format declaration braces.", !IsEnabled("RCS1076")));
            analyzers.Add(new BaseModel("RCS1077", "Optimize LINQ method call.", !IsEnabled("RCS1077")));
            analyzers.Add(new BaseModel("RCS1078", "Use \"\" instead of string.Empty.", !IsEnabled("RCS1078")));
            analyzers.Add(new BaseModel("RCS1079", "Throwing of new NotImplementedException.", !IsEnabled("RCS1079")));
            analyzers.Add(new BaseModel("RCS1080", "Use 'Count/Length' property instead of 'Any' method.", !IsEnabled("RCS1080")));
            analyzers.Add(new BaseModel("RCS1081", "Split variable declaration.", !IsEnabled("RCS1081")));
            analyzers.Add(new BaseModel("RCS1084", "Use coalesce expression instead of conditional expression.", !IsEnabled("RCS1084")));
            analyzers.Add(new BaseModel("RCS1085", "Use auto-implemented property.", !IsEnabled("RCS1085")));
            analyzers.Add(new BaseModel("RCS1086", "Use linefeed as newline.", !IsEnabled("RCS1086")));
            analyzers.Add(new BaseModel("RCS1087", "Use carriage return + linefeed as newline.", !IsEnabled("RCS1087")));
            analyzers.Add(new BaseModel("RCS1088", "Use space(s) instead of tab.", !IsEnabled("RCS1088")));
            analyzers.Add(new BaseModel("RCS1089", "Use --/++ operator instead of assignment.", !IsEnabled("RCS1089")));
            analyzers.Add(new BaseModel("RCS1090", "Call 'ConfigureAwait(false)'.", !IsEnabled("RCS1090")));
            analyzers.Add(new BaseModel("RCS1091", "Remove empty region.", !IsEnabled("RCS1091")));
            analyzers.Add(new BaseModel("RCS1092", "Add empty line before 'while' keyword in 'do' statement.", !IsEnabled("RCS1092")));
            analyzers.Add(new BaseModel("RCS1093", "Remove file with no code.", !IsEnabled("RCS1093")));
            analyzers.Add(new BaseModel("RCS1094", "Declare using directive on top level.", !IsEnabled("RCS1094")));
            analyzers.Add(new BaseModel("RCS1096", "Use bitwise operation instead of calling 'HasFlag'.", !IsEnabled("RCS1096")));
            analyzers.Add(new BaseModel("RCS1097", "Remove redundant 'ToString' call.", !IsEnabled("RCS1097")));
            analyzers.Add(new BaseModel("RCS1098", "Avoid 'null' on the left side of a binary expression.", !IsEnabled("RCS1098")));
            analyzers.Add(new BaseModel("RCS1099", "Default label should be the last label in a switch section.", !IsEnabled("RCS1099")));
            analyzers.Add(new BaseModel("RCS1100", "Format documentation summary on a single line.", !IsEnabled("RCS1100")));
            analyzers.Add(new BaseModel("RCS1101", "Format documentation summary on multiple lines.", !IsEnabled("RCS1101")));
            analyzers.Add(new BaseModel("RCS1102", "Make class static.", !IsEnabled("RCS1102")));
            analyzers.Add(new BaseModel("RCS1103", "Replace if statement with assignment.", !IsEnabled("RCS1103")));
            analyzers.Add(new BaseModel("RCS1104", "Simplify conditional expression.", !IsEnabled("RCS1104")));
            analyzers.Add(new BaseModel("RCS1105", "Unncessary interpolation.", !IsEnabled("RCS1105")));
            analyzers.Add(new BaseModel("RCS1106", "Remove empty destructor.", !IsEnabled("RCS1106")));
            analyzers.Add(new BaseModel("RCS1107", "Remove redundant 'ToCharArray' call.", !IsEnabled("RCS1107")));
            analyzers.Add(new BaseModel("RCS1108", "Add 'static' modifier to all partial class declarations.", !IsEnabled("RCS1108")));
            analyzers.Add(new BaseModel("RCS1110", "Declare type inside namespace.", !IsEnabled("RCS1110")));
            analyzers.Add(new BaseModel("RCS1111", "Add braces to switch section with multiple statements.", !IsEnabled("RCS1111")));
            analyzers.Add(new BaseModel("RCS1112", "Combine 'Enumerable.Where' method chain.", !IsEnabled("RCS1112")));
            analyzers.Add(new BaseModel("RCS1113", "Use 'string.IsNullOrEmpty' method.", !IsEnabled("RCS1113")));
            analyzers.Add(new BaseModel("RCS1114", "Remove redundant delegate creation.", !IsEnabled("RCS1114")));
            analyzers.Add(new BaseModel("RCS1118", "Mark local variable as const.", !IsEnabled("RCS1118")));
            analyzers.Add(new BaseModel("RCS1123", "Add parentheses according to operator precedence.", !IsEnabled("RCS1123")));
            analyzers.Add(new BaseModel("RCS1124", "Inline local variable.", !IsEnabled("RCS1124")));
            analyzers.Add(new BaseModel("RCS1126", "Add braces to if-else.", !IsEnabled("RCS1126")));
            analyzers.Add(new BaseModel("RCS1127", "Merge local declaration with assignment.", !IsEnabled("RCS1127")));
            analyzers.Add(new BaseModel("RCS1128", "Use coalesce expression.", !IsEnabled("RCS1128")));
            analyzers.Add(new BaseModel("RCS1129", "Remove redundant field initalization.", !IsEnabled("RCS1129")));
            analyzers.Add(new BaseModel("RCS1130", "Bitwise operation on enum without Flags attribute.", !IsEnabled("RCS1130")));
            analyzers.Add(new BaseModel("RCS1132", "Remove redundant overriding member.", !IsEnabled("RCS1132")));
            analyzers.Add(new BaseModel("RCS1133", "Remove redundant Dispose/Close call.", !IsEnabled("RCS1133")));
            analyzers.Add(new BaseModel("RCS1134", "Remove redundant statement.", !IsEnabled("RCS1134")));
            analyzers.Add(new BaseModel("RCS1135", "Declare enum member with zero value (when enum has FlagsAttribute).", !IsEnabled("RCS1135")));
            analyzers.Add(new BaseModel("RCS1136", "Merge switch sections with equivalent content.", !IsEnabled("RCS1136")));
            analyzers.Add(new BaseModel("RCS1138", "Add summary to documentation comment.", !IsEnabled("RCS1138")));
            analyzers.Add(new BaseModel("RCS1139", "Add summary element to documentation comment.", !IsEnabled("RCS1139")));
            analyzers.Add(new BaseModel("RCS1140", "Add exception to documentation comment.", !IsEnabled("RCS1140")));
            analyzers.Add(new BaseModel("RCS1141", "Add 'param' element to documentation comment.", !IsEnabled("RCS1141")));
            analyzers.Add(new BaseModel("RCS1142", "Add 'typeparam' element to documentation comment.", !IsEnabled("RCS1142")));
            analyzers.Add(new BaseModel("RCS1143", "Simplify coalesce expression.", !IsEnabled("RCS1143")));
            analyzers.Add(new BaseModel("RCS1145", "Remove redundant 'as' operator.", !IsEnabled("RCS1145")));
            analyzers.Add(new BaseModel("RCS1146", "Use conditional access.", !IsEnabled("RCS1146")));
            analyzers.Add(new BaseModel("RCS1151", "Remove redundant cast.", !IsEnabled("RCS1151")));
            analyzers.Add(new BaseModel("RCS1153", "Add empty line after closing brace.", !IsEnabled("RCS1153")));
            analyzers.Add(new BaseModel("RCS1154", "Sort enum members.", !IsEnabled("RCS1154")));
            analyzers.Add(new BaseModel("RCS1155", "Use StringComparison when comparing strings.", !IsEnabled("RCS1155")));
            analyzers.Add(new BaseModel("RCS1156", "Use string.Length instead of comparison with empty string.", !IsEnabled("RCS1156")));
            analyzers.Add(new BaseModel("RCS1157", "Composite enum value contains undefined flag.", !IsEnabled("RCS1157")));
            analyzers.Add(new BaseModel("RCS1158", "Static member in generic type should use a type parameter.", !IsEnabled("RCS1158")));
            analyzers.Add(new BaseModel("RCS1159", "Use EventHandler<T>.", !IsEnabled("RCS1159")));
            analyzers.Add(new BaseModel("RCS1160", "Abstract type should not have public constructors.", !IsEnabled("RCS1160")));
            analyzers.Add(new BaseModel("RCS1161", "Enum should declare explicit values.", !IsEnabled("RCS1161")));
            analyzers.Add(new BaseModel("RCS1162", "Avoid chain of assignments.", !IsEnabled("RCS1162")));
            analyzers.Add(new BaseModel("RCS1163", "Unused parameter.", !IsEnabled("RCS1163")));
            analyzers.Add(new BaseModel("RCS1164", "Unused type parameter.", !IsEnabled("RCS1164")));
            analyzers.Add(new BaseModel("RCS1165", "Unconstrained type parameter checked for null.", !IsEnabled("RCS1165")));
            analyzers.Add(new BaseModel("RCS1166", "Value type object is never equal to null.", !IsEnabled("RCS1166")));
            analyzers.Add(new BaseModel("RCS1168", "Parameter name differs from base name.", !IsEnabled("RCS1168")));
            analyzers.Add(new BaseModel("RCS1169", "Mark field as read-only.", !IsEnabled("RCS1169")));
            analyzers.Add(new BaseModel("RCS1170", "Use read-only auto-implemented property.", !IsEnabled("RCS1170")));
            analyzers.Add(new BaseModel("RCS1171", "Simplify lazy initialization.", !IsEnabled("RCS1171")));
            analyzers.Add(new BaseModel("RCS1172", "Use 'is' operator instead of 'as' operator.", !IsEnabled("RCS1172")));
            analyzers.Add(new BaseModel("RCS1173", "Use coalesce expression instead of if.", !IsEnabled("RCS1173")));
            analyzers.Add(new BaseModel("RCS1174", "Remove redundant async/await.", !IsEnabled("RCS1174")));
            analyzers.Add(new BaseModel("RCS1175", "Unused this parameter.", !IsEnabled("RCS1175")));
            analyzers.Add(new BaseModel("RCS1176", "Use 'var' instead of explicit type (when the type is not obvious).", !IsEnabled("RCS1176")));
            analyzers.Add(new BaseModel("RCS1177", "Use 'var' instead of explicit type (in foreach).", !IsEnabled("RCS1177")));
            analyzers.Add(new BaseModel("RCS1179", "Use return instead of assignment.", !IsEnabled("RCS1179")));
            analyzers.Add(new BaseModel("RCS1180", "Inline lazy initialization.", !IsEnabled("RCS1180")));
            analyzers.Add(new BaseModel("RCS1181", "Convert comment to documentation comment.", !IsEnabled("RCS1181")));
            analyzers.Add(new BaseModel("RCS1182", "Remove redundant base interface.", !IsEnabled("RCS1182")));
            analyzers.Add(new BaseModel("RCS1183", "Format initializer with single expression on single line.", !IsEnabled("RCS1183")));
            analyzers.Add(new BaseModel("RCS1184", "Format conditional expression (format ? and : on next line).", !IsEnabled("RCS1184")));
            analyzers.Add(new BaseModel("RCS1185", "Format single-line block.", !IsEnabled("RCS1185")));
            analyzers.Add(new BaseModel("RCS1186", "Use Regex instance instead of static method.", !IsEnabled("RCS1186")));
            analyzers.Add(new BaseModel("RCS1187", "Use constant instead of field.", !IsEnabled("RCS1187")));
            analyzers.Add(new BaseModel("RCS1188", "Remove redundant auto-property initialization.", !IsEnabled("RCS1188")));
            analyzers.Add(new BaseModel("RCS1189", "Add or remove region name.", !IsEnabled("RCS1189")));
            analyzers.Add(new BaseModel("RCS1190", "Join string expressions.", !IsEnabled("RCS1190")));
            analyzers.Add(new BaseModel("RCS1191", "Declare enum value as combination of names.", !IsEnabled("RCS1191")));
            analyzers.Add(new BaseModel("RCS1192", "Use regular string literal instead of verbatim string literal.", !IsEnabled("RCS1192")));
            analyzers.Add(new BaseModel("RCS1193", "Overriding member cannot change 'params' modifier.", !IsEnabled("RCS1193")));
            analyzers.Add(new BaseModel("RCS1194", "Implement exception constructors.", !IsEnabled("RCS1194")));
            analyzers.Add(new BaseModel("RCS1195", "Use ^ operator.", !IsEnabled("RCS1195")));
            analyzers.Add(new BaseModel("RCS1196", "Call extension method as instance method.", !IsEnabled("RCS1196")));
            analyzers.Add(new BaseModel("RCS1197", "Optimize StringBuilder.Append/AppendLine call.", !IsEnabled("RCS1197")));
            analyzers.Add(new BaseModel("RCS1198", "Avoid unnecessary boxing of value type.", !IsEnabled("RCS1198")));
            analyzers.Add(new BaseModel("RCS1199", "Simplify boolean expression.", !IsEnabled("RCS1199")));
            analyzers.Add(new BaseModel("RCS1200", "Call 'Enumerable.ThenBy' instead of 'Enumerable.OrderBy'.", !IsEnabled("RCS1200")));
            analyzers.Add(new BaseModel("RCS1201", "Use method chaining.", !IsEnabled("RCS1201")));
            analyzers.Add(new BaseModel("RCS1202", "Avoid NullReferenceException.", !IsEnabled("RCS1202")));
            analyzers.Add(new BaseModel("RCS1203", "Use AttributeUsageAttribute.", !IsEnabled("RCS1203")));
            analyzers.Add(new BaseModel("RCS1204", "Use EventArgs.Empty.", !IsEnabled("RCS1204")));
            analyzers.Add(new BaseModel("RCS1205", "Order named arguments according to the order of parameters.", !IsEnabled("RCS1205")));
            analyzers.Add(new BaseModel("RCS1206", "Use conditional access instead of conditional expression.", !IsEnabled("RCS1206")));
            analyzers.Add(new BaseModel("RCS1207", "Use method group instead of anonymous function.", !IsEnabled("RCS1207")));
            analyzers.Add(new BaseModel("RCS1208", "Reduce if nesting.", !IsEnabled("RCS1208")));
            analyzers.Add(new BaseModel("RCS1209", "Order type parameter constraints.", !IsEnabled("RCS1209")));
            analyzers.Add(new BaseModel("RCS1210", "Return Task.FromResult instead of returning null.", !IsEnabled("RCS1210")));
            analyzers.Add(new BaseModel("RCS1211", "Remove unnecessary else clause.", !IsEnabled("RCS1211")));
            analyzers.Add(new BaseModel("RCS1212", "Remove redundant assignment.", !IsEnabled("RCS1212")));
            analyzers.Add(new BaseModel("RCS1213", "Remove unused member declaration.", !IsEnabled("RCS1213")));
            analyzers.Add(new BaseModel("RCS1214", "Unnecessary interpolated string.", !IsEnabled("RCS1214")));
            analyzers.Add(new BaseModel("RCS1215", "Expression is always equal to true/false.", !IsEnabled("RCS1215")));
            analyzers.Add(new BaseModel("RCS1216", "Unnecessary unsafe context.", !IsEnabled("RCS1216")));
            analyzers.Add(new BaseModel("RCS1217", "Replace interpolated string with concatenation.", !IsEnabled("RCS1217")));
            analyzers.Add(new BaseModel("RCS1218", "Simplify code branching.", !IsEnabled("RCS1218")));
            analyzers.Add(new BaseModel("RCS1219", "Call 'Enumerable.Skip' and 'Enumerable.Any' instead of 'Enumerable.Count'.", !IsEnabled("RCS1219")));
            analyzers.Add(new BaseModel("RCS1220", "Use pattern matching instead of combination of 'is' operator and cast operator.", !IsEnabled("RCS1220")));
            analyzers.Add(new BaseModel("RCS1221", "Use pattern matching instead of combination of 'as' operator and null check.", !IsEnabled("RCS1221")));
            analyzers.Add(new BaseModel("RCS1222", "Merge preprocessor directives.", !IsEnabled("RCS1222")));
            analyzers.Add(new BaseModel("RCS1223", "Mark publicly visible type with DebuggerDisplay attribute.", !IsEnabled("RCS1223")));
            analyzers.Add(new BaseModel("RCS1224", "Make method an extension method.", !IsEnabled("RCS1224")));
            analyzers.Add(new BaseModel("RCS1225", "Make class sealed.", !IsEnabled("RCS1225")));
            analyzers.Add(new BaseModel("RCS1226", "Add paragraph to documentation comment.", !IsEnabled("RCS1226")));
            analyzers.Add(new BaseModel("RCS1227", "Validate arguments correctly.", !IsEnabled("RCS1227")));
            analyzers.Add(new BaseModel("RCS1228", "Unused element in documentation comment.", !IsEnabled("RCS1228")));
            analyzers.Add(new BaseModel("RCS1229", "Use async/await when necessary.", !IsEnabled("RCS1229")));
            analyzers.Add(new BaseModel("RCS1230", "Unnecessary usage of enumerator.", !IsEnabled("RCS1230")));
            analyzers.Add(new BaseModel("RCS1231", "Make parameter ref read-only.", !IsEnabled("RCS1231")));
            analyzers.Add(new BaseModel("RCS1232", "Order elements in documentation comment.", !IsEnabled("RCS1232")));
            analyzers.Add(new BaseModel("RCS1233", "Use short-circuiting operator.", !IsEnabled("RCS1233")));
            analyzers.Add(new BaseModel("RCS1234", "Duplicate enum value.", !IsEnabled("RCS1234")));
            analyzers.Add(new BaseModel("RCS1235", "Optimize method call.", !IsEnabled("RCS1235")));
            analyzers.Add(new BaseModel("RCS1245", "Remove unnecessary new line.", !IsEnabled("RCS1245")));
        }
    }
}