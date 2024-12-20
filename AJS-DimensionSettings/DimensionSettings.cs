using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.DatabaseServices;
using System;

namespace AJS_DimensionSettings
{
    public static class DimensionSettings
    {
        /// <summary>
        /// <para> !DIMADEC! </para>
        /// <para> Example: 0 </para>
        /// <para> Số chữ số thập phân Dim góc </para>
        /// <para> Controls the number of precision places displayed in angular dimensions. </para>

        /// <para> Value	Description </para>
        /// <para> -1		Angular dimensions display the number of decimal places specified by DIMDEC </para>
        /// <para> 0-8		Specifies the number of decimal places displayed in angular dimensions (independent of DIMDEC) </para>
        /// </summary>
        public static int AngularDecimal(this Dimension rd, int value) => rd.Dimadec = value;

        /// <summary>
        /// <para> !DIMALT! </para>
        /// <para> Example: false </para>

        /// <para> Controls the display of alternate units in dimensions. </para>

        /// <para> Value	Description </para>
        /// <para> false		Disables alternate units </para>
        /// <para> true		Enables alternate units </para>
        /// </summary>
        public static bool AlternateUnits(this Dimension rd, bool value) => rd.Dimalt = value;

        /// <summary>
        /// <para> !DIMALTD! </para>
        /// <para> Example: 2 (imperial) or 3 (metric) </para>
        /// <para> Controls the number of decimal places in alternate units. </para>

        /// <para> If DIMALT is turned on, DIMALTD sets the number of digits displayed to the right of the decimal point in the alternate measurement.  </para>
        /// </summary>
        public static int AlternateUnitsDecimal(this Dimension rd, int value) => rd.Dimaltd = value;

        /// <summary>
        /// <para> !DIMALTF! </para>
        /// <para> Example: 25.4000 (imperial) or 0.0394 (metric) </para>
        /// <para> Controls the multiplier for alternate units. </para>

        /// <para> If DIMALT is turned on, DIMALTF multiplies linear dimensions by a factor to produce a value in an alternate system of measurement. The initial value represents the number of millimeters in an inch.  </para>
        /// </summary>
        //public static double AlternateUnitsMultiplier(this Dimension rd, double value) => rd.Dimaltf = value;

        /// <summary>
        /// <para> !DIMALTRND! </para>
        /// <para> Example: 0.0000 </para>
        /// <para> Làm tròn đơn vị </para>
        /// <para> Rounds off the alternate dimension units. </para>
        /// </summary>
        //public static double PrecisionRound(this Dimension rd, double value = 0.0) => rd.Dimaltrnd = value;

        /// <summary>
        /// <para> !DIMALTTD! </para>
        /// <para> Example: 2 (imperial) or 3 (metric) </para>
        /// <para> Số chữ số thập phân </para>
        /// <para> Sets the number of decimal places for the tolerance values in the alternate units of a dimension. </para>
        /// </summary>
        //public static int AlternateUnitsTolerance(this Dimension rd, int value) => rd.Dimalttd = value;

        /// <summary>
        /// <para> !DIMALTTZ! </para>
        /// <para> Example: 0 </para>
        /// <para> Controls suppression of zeros in tolerance values. </para>

        /// <para> Value	Description </para>
        /// <para> 0		Suppresses zero feet and precisely zero inches </para>
        /// <para> 1		Includes zero feet and precisely zero inches </para>
        /// <para> 2		Includes zero feet and suppresses zero inches </para>
        /// <para> 3		Includes zero inches and suppresses zero feet </para>

        /// <para> To suppress leading or trailing zeros, add the following values to one of the preceding values: </para>

        /// <para> Value	Description </para>
        /// <para> 4		Suppresses leading zeros </para>
        /// <para> 8		Suppresses trailing zeros </para>
        /// </summary>
        //public static int AlternateUnitsSuppression(this Dimension rd, int value) => rd.Dimalttz = value;

        /// <summary>
        /// <para> !DIMALTU! </para>
        /// <para> Example: 2 </para>
        /// <para> Sets the units format for alternate units of all dimension substyles except Angular. </para>

        /// <para> Value	Description </para>
        /// <para> 1		Scientific </para>
        /// <para> 2		Decimal </para>
        /// <para> 3		Engineering </para>
        /// <para> 4		Architectural (stacked) </para>
        /// <para> 5		Fractional (stacked) </para>
        /// <para> 6		Architectural </para>
        /// <para> 7		Fractional </para>
        /// <para> 8		Microsoft Windows Desktop (decimal format using Control Panel settings for decimal separator and number grouping symbols) </para>
        /// </summary>
        //public static int SetDimaltu(this Dimension rd, int value) => rd.Dimaltu = value;

        /// <summary>
        /// <para> !DIMALTZ! </para>
        /// <para> Example: 0 </para>
        /// <para> Controls the suppression of zeros for alternate unit dimension values. </para>

        /// <para> DIMALTZ values 0-3 affect feet-and-inch dimensions only. </para>

        /// <para> Value	Description </para>
        /// <para> 0		Suppresses zero feet and precisely zero inches </para>
        /// <para> 1		Includes zero feet and precisely zero inches </para>
        /// <para> 2		Includes zero feet and suppresses zero inches </para>
        /// <para> 3		Includes zero inches and suppresses zero feet </para>
        /// <para> 4		Suppresses leading zeros in decimal dimensions (for example, 0.5000 becomes .5000) </para>
        /// <para> 8		Suppresses trailing zeros in decimal dimensions (for example, 12.5000 becomes 12.5) </para>
        /// <para> 12		Suppresses both leading and trailing zeros (for example, 0.5000 becomes .5) </para>
        /// </summary>
        //public static int SetDimaltz(this Dimension rd, int value) => rd.Dimaltz = value;

        /// <summary>
        /// <para> !DIMAPOST! </para>
        /// <para> Example: "" </para>
        /// <para> Specifies a text prefix or suffix (or both) to the alternate dimension measurement for all types of dimensions except angular. </para>

        /// <para> For instance, if the current units are Architectural, DIMALT is on, DIMALTF is 25.4 (the number of millimeters per inch), DIMALTD is 2, and DIMAPOST is set to "mm", a distance of 10 units would be displayed as 10"[254.00mm]. </para>

        /// <para> To turn off an established prefix or suffix (or both), set it to a single period (.).  </para>
        /// </summary>
        //public static string SetDimapost(this Dimension rd, string value) => rd.Dimapost = value;

        /// <summary>
        /// <para> !DIMARCSYM! </para>
        /// <para> Example: 0 </para>
        /// <para> Tùy chọn biểu tượng ARC </para>
        /// <para> Controls display of the arc symbol in an arc length dimension. </para>

        /// <para> Value	Description </para>
        /// <para> 0		Places arc length symbols before the dimension text </para>
        /// <para> 1		Places arc length symbols above the dimension text </para>
        /// <para> 2		Suppresses the display of arc length symbols </para>
        /// </summary>
        public static int ArcSymbol(this Dimension rd, int value) => rd.Dimarcsym = value;

        /// <summary>
        /// <para> !DIMASZ! </para>
        /// <para> Example: 0.1800 (imperial) or 2.5000 (metric) </para>
        /// <para> Tỉ lệ đường Line và mũi tên Leader </para>
        /// <para> Controls the size of dimension line and leader line arrowheads. Also controls the size of hook lines. </para>

        /// <para> Multiples of the arrowhead size determine whether dimension lines and text should fit between the extension lines. DIMASZ is also used to scale arrowhead blocks if set by DIMBLK. DIMASZ has no effect when DIMTSZ is other than zero.  </para>
        /// </summary>
        public static double ArrowheadSize(this Dimension rd, double value) => rd.Dimasz = value;

        public enum DIMATFIT
        { Outsize, ArrowFirst, TextFirst, Both }

        /// <summary>
        /// <para> !DIMATFIT! </para>
        /// <para> Example: 3 </para>
        /// <para> Tùy chọn Fit </para>
        /// <para> Determines how dimension text and arrows are arranged when space is not sufficient to place both within the extension lines. </para>

        /// <para> Value	Description </para>
        /// <para> 0		Places both text and arrows outside extension lines </para>
        /// <para> 1		Moves arrows first, then text </para>
        /// <para> 2		Moves text first, then arrows </para>
        /// <para> 3		Moves either text or arrows, whichever fits best </para>

        /// <para> A leader is added to moved dimension text when DIMTMOVE is set to 1.  </para>
        /// </summary>
        public static int Fit(this Dimension rd, DIMATFIT value) => rd.Dimatfit = (int)value;

        /// <summary>
        /// <para> !DIMAUNIT! </para>
        /// <para> Example: 0 </para>
        /// <para> Đơn vị góc đo </para>
        /// <para> Sets the units format for angular dimensions. </para>

        /// <para> Value	Description </para>
        /// <para> 0		Decimal degrees </para>
        /// <para> 1		Degrees/minutes/seconds </para>
        /// <para> 2		Gradians </para>
        /// <para> 3		Radians </para>
        /// </summary>
        public static int AngularUnits(this Dimension rd, int value) => rd.Dimaunit = value;

        /// <summary>
        /// <para> !DIMAZIN! </para>
        /// <para> Example: 0 </para>
        /// <para> Loại bỏ số 0 </para>
        /// <para> Suppresses zeros for angular dimensions. </para>
        /// <para> Value	Description </para>
        /// <para> 0		Displays all leading and trailing zeros </para>
        /// <para> 1		Suppresses leading zeros in decimal dimensions (for example, 0.5000 becomes .5000) </para>
        /// <para> 2		Suppresses trailing zeros in decimal dimensions (for example, 12.5000 becomes 12.5) </para>
        /// <para> 3		Suppresses leading and trailing zeros (for example, 0.5000 becomes .5) </para>
        /// </summary>
        public static int AngularSuppressesZero(this Dimension rd, int value) => rd.Dimazin = value;

        /// <summary>
        /// <para> ""					closed filled </para>
        /// <para> "_DOT"				dot </para>
        /// <para> "_DOTSMALL"		dot small </para>
        /// <para> "_DOTBLANK"		dot blank </para>
        /// <para> "_ORIGIN"			origin indicator </para>
        /// <para> "_ORIGIN2"			origin indicator 2 </para>
        /// <para> "_OPEN"			open </para>
        /// <para> "_OPEN90"			right angle </para>
        /// <para> "_OPEN30"			open 30 </para>
        /// <para> "_CLOSED"			closed </para>
        /// <para> "_SMALL"			dot small blank </para>
        /// <para> "_NONE"			none </para>
        /// <para> "_OBLIQUE"		oblique </para>
        /// <para> "_BOXFILLED"		box filled </para>
        /// <para> "_BOXBLANK"		box </para>
        /// <para> "_CLOSEDBLANK"	closed blank </para>
        /// <para> "_DATUMFILLED"	datum triangle filled </para>
        /// <para> "_DATUMBLANK"	datum triangle </para>
        /// <para> "_INTEGRAL"		integral </para>
        /// <para> "_ARCHTICK"		architectural tick </para>
        /// </summary>
        public enum ArrowHead
        {
            ClosedFilled, DOT, DOTSMALL, DOTBLANK, ORIGIN, ORIGIN2, OPEN, OPEN90, OPEN30, CLOSED, SMALL, NONE, OBLIQUE, BOXFILLED,

            BOXBLANK, CLOSEDBLANK, DATUMFILLED, DATUMBLANK, INTEGRAL, ARCHTICK
        }

        /// <summary>
        /// <para> !DIMBLK! </para>
        /// <para> Example: "" </para>
        /// <para> Block đầu mũi tên </para>
        /// <para> Sets the arrowhead block displayed at the ends of dimension lines. </para>
        /// <para> To return to the default, closed-filled arrowhead display, enter a single period (.). Arrowhead block entries and the names used to select them in the New, Modify, and Override Dimension Style dialog boxes are shown below. You can also enter the names of user-defined arrowhead blocks. </para>
        /// <para> NOTE: Annotative blocks cannot be used as custom arrowheads for dimensions or leaders. </para>
        /// <para> Value				Description </para>
        /// <para> ""					closed filled </para>
        /// <para> "_DOT"				dot </para>
        /// <para> "_DOTSMALL"		dot small </para>
        /// <para> "_DOTBLANK"		dot blank </para>
        /// <para> "_ORIGIN"			origin indicator </para>
        /// <para> "_ORIGIN2"			origin indicator 2 </para>
        /// <para> "_OPEN"			open </para>
        /// <para> "_OPEN90"			right angle </para>
        /// <para> "_OPEN30"			open 30 </para>
        /// <para> "_CLOSED"			closed </para>
        /// <para> "_SMALL"			dot small blank </para>
        /// <para> "_NONE"			none </para>
        /// <para> "_OBLIQUE"		oblique </para>
        /// <para> "_BOXFILLED"		box filled </para>
        /// <para> "_BOXBLANK"		box </para>
        /// <para> "_CLOSEDBLANK"	closed blank </para>
        /// <para> "_DATUMFILLED"	datum triangle filled </para>
        /// <para> "_DATUMBLANK"	datum triangle </para>
        /// <para> "_INTEGRAL"		integral </para>
        /// <para> "_ARCHTICK"		architectural tick </para>
        /// </summary>
        public static void SetBlock(this Dimension rd, string value) => rd.Dimblk = HostApplicationServices.WorkingDatabase.Search(value, TBType.Block);

        public static void SetBlock(this Dimension rd, ArrowHead value) => rd.Dimblk = HostApplicationServices.WorkingDatabase.Search("_" + value.ToString(), TBType.Block);

        /// <summary>
        /// <para> !DIMBLK1! </para>
        /// <para> Example: "" </para>
        /// <para> Đầu mũi tên 1 khi Dimsah = true </para>
        /// <para> Sets the arrowhead for the first end of the dimension line when DIMSAH is on. </para>

        /// <para> To return to the default, closed-filled arrowhead display, enter a single period (.). For a list of arrowheads, see DIMBLK. </para>

        /// <para> NOTE: Annotative blocks cannot be used as custom arrowheads for dimensions or leaders. </para>
        /// </summary>
        public static void SetBlock1(this Dimension rd, string value)
        {
            rd.Dimsah = true;
            rd.Dimblk1 = HostApplicationServices.WorkingDatabase.Search(value, TBType.Block);
            return;
        }

        /// <summary>
        /// <para> !DIMBLK1! </para>
        /// <para> Example: "" </para>
        /// <para> Đầu mũi tên 1 khi Dimsah = true </para>
        /// <para> Sets the arrowhead for the first end of the dimension line when DIMSAH is on. </para>

        /// <para> To return to the default, closed-filled arrowhead display, enter a single period (.). For a list of arrowheads, see DIMBLK. </para>

        /// <para> NOTE: Annotative blocks cannot be used as custom arrowheads for dimensions or leaders. </para>
        /// </summary>
        public static void SetBlock1(this Dimension rd, ArrowHead value)
        {
            rd.Dimsah = true;
            rd.Dimblk1 = HostApplicationServices.WorkingDatabase.Search("_" + value.ToString(), TBType.Block);
            return;
        }

        /// <summary>
        /// <para> !DIMBLK2! </para>
        /// <para> Example: "" </para>
        /// <para> Đầu mũi tên 2 khi Dimsah = true </para>
        /// <para> Sets the arrowhead for the second end of the dimension line when DIMSAH is on. </para>

        /// <para> To return to the default, closed-filled arrowhead display, enter a single period (.). For a list of arrowhead entries, see DIMBLK. </para>

        /// <para> NOTE: Annotative blocks cannot be used as custom arrowheads for dimensions or leaders. </para>
        /// </summary>
        public static void SetBlock2(this Dimension rd, string value)
        {
            rd.Dimsah = true;
            rd.Dimblk2 = HostApplicationServices.WorkingDatabase.Search(value, TBType.Block);
        }

        /// <summary>
        /// <para> !DIMBLK2! </para>
        /// <para> Example: "" </para>
        /// <para> Đầu mũi tên 2 khi Dimsah = true </para>
        /// <para> Sets the arrowhead for the second end of the dimension line when DIMSAH is on. </para>

        /// <para> To return to the default, closed-filled arrowhead display, enter a single period (.). For a list of arrowhead entries, see DIMBLK. </para>

        /// <para> NOTE: Annotative blocks cannot be used as custom arrowheads for dimensions or leaders. </para>
        /// </summary>
        public static void SetBlock2(this Dimension rd, ArrowHead value)
        {
            rd.Dimsah = true;
            rd.Dimblk2 = HostApplicationServices.WorkingDatabase.Search("_" + value.ToString(), TBType.Block);
        }

        /// <summary>
        /// <para> !DIMCEN! </para>
        /// <para> Example: 0.0900 (imperial) or 2.5000 (metric) </para>
        /// <para> Hiển thị nét Tim </para>
        /// <para> Controls drawing of circle or arc center marks and centerlines by the DIMCENTER, DIMDIAMETER, and DIMRADIUS commands. </para>

        /// <para> For DIMDIAMETER and DIMRADIUS, the center mark is drawn only if you place the dimension line outside the circle or arc. </para>

        /// <para> Value	Description </para>
        /// <para> 0		No center marks or lines are drawn </para>
        /// <para> <0		Centerlines are drawn </para>
        /// <para> >0		Center marks are drawn </para>

        /// <para> The absolute value specifies the size of the center mark or centerline. </para>

        /// <para> The size of the centerline is the length of the centerline segment that extends outside the circle or arc. It is also the size of the gap between the center mark and the start of the centerline. </para>

        /// <para> The size of the center mark is the distance from the center of the circle or arc to the end of the center mark.  </para>
        /// </summary>
        public static double SetCenterRadius(this Dimension rd, double value) => rd.Dimcen = value;

        /// <summary>
        /// <para> !DIMCLRD! </para>
        /// <para> Example: 0 </para>
        /// <para> Màu sắc đường line, mũi tên, leader </para>
        /// <para> Assigns colors to dimension lines, arrowheads, and dimension leader lines. </para>

        /// <para> Also controls the color of leader lines created with the LEADER command. Color numbers are displayed in the Select Color dialog box. For BYBLOCK, enter 0. For BYLAYER, enter 256.  </para>
        /// </summary>
        public static void SetLineColor(this Dimension rd, int value)
            => rd.Dimclrd = Color.FromColorIndex(ColorMethod.ByAci, (short)value);

        /// <summary>
        /// <para> !DIMCLRE! </para>
        /// <para> Example: 0 </para>
        /// <para> Assigns colors to extension lines, center marks, and centerlines. </para>

        /// <para> Color numbers are displayed in the Select Color dialog box. For BYBLOCK, enter 0. For BYLAYER, enter 256.  </para>
        /// </summary>
        public static void SetExtensionColor(this Dimension rd, int value) => rd.Dimclre = Color.FromColorIndex(ColorMethod.ByAci, (short)value);

        /// <summary>
        /// <para> !DIMCLRT! </para>
        /// <para> Example: 0 </para>
        /// <para> Assigns colors to dimension text. </para>

        /// <para> The color can be any valid color number.  </para>
        /// </summary>
        public static void SetTextColor(this Dimension rd, int value) => rd.Dimclrt = Color.FromColorIndex(ColorMethod.ByAci, (short)value);

        /// <summary>
        /// <para> !DIMDEC! </para>
        /// <para> Example: 4 (imperial) or 2 (metric) </para>
        /// <para> Số chữ thập phân </para>
        /// <para> Sets the number of decimal places displayed for the primary units of a dimension. </para>

        /// <para> The precision is based on the units or angle format you have selected. Specified value is applied to angular dimensions when DIMADEC is set to -1.  </para>
        /// </summary>
        public static int SetDecimalPlaces(this Dimension rd, int value) => rd.Dimdec = value;

        /// <summary>
        /// <para> !DIMDLE! </para>
        /// <para> Example: 0.0000 </para>
        /// <para> Khoảng cách extend </para>
        /// <para> Sets the distance the dimension line extends beyond the extension line when oblique strokes are drawn instead of arrowheads. </para>
        /// </summary>
        public static double SetExtendDistance(this Dimension rd, double value) => rd.Dimdle = value;

        /// <summary>
        /// <para> !DIMDLI! </para>
        /// <para> Example: 0.3800 (imperial) or 3.7500 (metric) </para>
        /// <para> Khoảng cách đường gióng và đường cơ sở </para>
        /// <para> Controls the spacing of the dimension lines in baseline dimensions. </para>

        /// <para> Each dimension line is offset from the previous one by this amount, if necessary, to avoid drawing over it. Changes made with DIMDLI are not applied to existing dimensions.  </para>
        /// </summary>
        public static double SetSpacingDimension(this Dimension rd, double value) => rd.Dimdli = value;

        /// <summary>
        /// <para> !DIMDSEP! </para>
        /// <para> . (imperial) or , (metric) </para>
        /// <para> Specifies a single-character decimal separator to use when creating dimensions whose unit format is decimal. </para>

        /// <para> When prompted, enter a single character at the Command prompt. If dimension units is set to Decimal, the DIMDSEP character is used instead of the default decimal point. If DIMDSEP is set to NULL (default value, reset by entering a period), the decimal point is used as the dimension separator.  </para>
        /// <para> #DIMDSEP# </para>
        public static double SetDecimalSeparator(this Dimension rd, string value) => rd.Dimdsep = value[0];

        /// <summary>
        /// <para> !DIMEXE! </para>
        /// <para> Example: 0.1800 (imperial) or 1.2500 (metric) </para>
        /// <para> Khoảng cách kéo dài đường gióng </para>
        /// <para> Specifies how far to extend the extension line beyond the dimension line. </para>
        /// </summary>
        public static double SetExtendExtension(this Dimension rd, double value) => rd.Dimexe = value;

        /// <summary>
        /// <para> !DIMEXO! </para>
        /// <para> Example: 0.0625 (imperial) or 0.6250 (metric) </para>
        /// <para> Khoảng cách đường gióng và điểm point </para>
        /// <para> Specifies how far extension lines are offset from origin points. </para>

        /// <para> With fixed-length extension lines, this value determines the minimum offset.  </para>
        /// </summary>
        public static double SetDistancePoint(this Dimension rd, double value) => rd.Dimexo = value;

        /// <summary>
        /// <para> !DIMFRAC! </para>
        /// <para> Example: 0 </para>
        /// <para> Sets the fraction format when DIMLUNIT is set to 4 (Architectural) or 5 (Fractional). </para>

        /// <para> Value	Description </para>
        /// <para> 0		Horizontal stacking </para>
        /// <para> 1		Diagonal stacking </para>
        /// <para> 2		Not stacked (for example, 1/2) </para>
        /// </summary>
        //public static int SetDimfrac(this Dimension rd, int value) => rd.Dimfrac = value;

        /// <summary>
        /// <para> !DIMFXL! </para>
        /// <para> Example: 1.0000 </para>
        /// <para> Sets the total length of the extension lines starting from the dimension line toward the dimension origin. </para>
        /// </summary>
        public static double SetDimfxlen(this Dimension rd, double value) => rd.Dimfxlen = value;

        /// <summary>
        /// <para> !DIMFXLON! </para>
        /// <para> Example: false </para>
        /// <para> Controls whether extension lines are set to a fixed length. </para>

        /// <para> When DIMFXLON is on, extension lines are set to the length specified by DIMFXL.  </para>
        /// </summary>
        //public static bool SetDimfxlon(this Dimension rd, bool value) => rd.Dimfxlon = value;

        /// <summary>
        /// <para> !DIMGAP! </para>
        /// <para> Example: 0.0900 (imperial) or 0.6250 (metric) </para>
        /// <para> Sets the distance around the dimension text when the dimension line breaks to accommodate dimension text. </para>

        /// <para> Also sets the gap between annotation and a hook line created with the LEADER command. If you enter a negative value, DIMGAP places a box around the dimension text. </para>

        /// <para> The value of DIMGAP is also used as the minimum length of each segment of the dimension line. To locate the components of a linear dimension within the extension lines, enough space must be available for both arrowheads (2 x DIMASZ), both dimension line segments (2 x DIMGAP), a gap on either side of the dimension text (another 2 x DIMGAP), and the length of the dimension text, which depends on its size and number of decimal places displayed.  </para>
        /// </summary>
        public static double SetDimgap(this Dimension rd, double value) => rd.Dimgap = value;

        /// <summary>
        /// <para> !DIMJOGANG! </para>
        /// <para> Example: 45 </para>
        /// <para> Determines the angle of the transverse segment of the dimension line in a jogged radius dimension. </para>

        /// <para> Jogged radius dimensions are often created when the center point is located off the page. Valid settings range is 5 to 90.  </para>
        /// </summary>
        public static double SetDimjogang(this Dimension rd, double value) => rd.Dimjogang = value;

        /// <summary>
        /// <para> !DIMJUST! </para>
        /// <para> Example: 0 </para>
        /// <para> Controls the horizontal positioning of dimension text. </para>

        /// <para> Value	Description </para>
        /// <para> 0		Positions the text above the dimension line and center-justifies it between the extension lines </para>
        /// <para> 1		Positions the text next to the first extension line </para>
        /// <para> 2		Positions the text next to the second extension line </para>
        /// <para> 3		Positions the text above and aligned with the first extension line </para>
        /// <para> 4		Positions the text above and aligned with the second extension line </para>
        /// </summary>
        public static int SetHorizontalJustify(this Dimension rd, int value) => rd.Dimjust = value;

        /// <summary>
        /// <para> !DIMLAYER! </para>
        /// <para> Example: use current </para>
        /// <para> Specifies a default layer for new dimensions. </para>

        /// <para> Values other than the "." (use current) value override the current layer (CLAYER system variable).  </para>
        /// </summary>
        //public static string SetDimlayer(this Dimension rd, string value) => rd.SetDimlayer = value;

        /// <summary>
        /// <para> !DIMLDRBLK! </para>
        /// <para> Example: "" </para>
        /// <para> Specifies the arrow type for leaders. </para>

        /// <para> To return to the default, closed-filled arrowhead display, enter a single period (.). For a list of arrowhead entries, see DIMBLK. </para>

        /// <para> NOTE: Annotative blocks cannot be used as custom arrowheads for dimensions or leaders. </para>
        /// </summary>
        public static ObjectId SetDimldrblk(this Dimension rd, string value) => rd.Dimldrblk = HostApplicationServices.WorkingDatabase.Search(value, TBType.Block);

        /// <summary>
        /// <para> !DIMLDRBLK! </para>
        /// <para> Example: "" </para>
        /// <para> Specifies the arrow type for leaders. </para>

        /// <para> To return to the default, closed-filled arrowhead display, enter a single period (.). For a list of arrowhead entries, see DIMBLK. </para>

        /// <para> NOTE: Annotative blocks cannot be used as custom arrowheads for dimensions or leaders. </para>
        /// </summary>
        public static ObjectId SetDimldrblk(this Dimension rd, ArrowHead value) => rd.Dimldrblk = HostApplicationServices.WorkingDatabase.Search("_" + value.ToString(), TBType.Block);

        /// <summary>
        /// <para> !DIMLFAC! </para>
        /// <para> Example: 1.0000 </para>
        /// <para> Sets a scale factor for linear dimension measurements. </para>

        /// <para> All linear dimension distances, including radii, diameters, and coordinates, are multiplied by DIMLFAC before being converted to dimension text. Positive values of DIMLFAC are applied to dimensions in both model space and paper space; negative values are applied to paper space only. </para>

        /// <para> DIMLFAC applies primarily to nonassociative dimensions (DIMASSOC set 0 or 1). For nonassociative dimensions in paper space, DIMLFAC must be set individually for each layout viewport to accommodate viewport scaling. </para>

        /// <para> DIMLFAC has no effect on angular dimensions, and is not applied to the values held in DIMRND, DIMTM, or DIMTP.  </para>
        /// </summary>
        public static double SetDimlinearFactor(this Dimension rd, double value) => rd.Dimlfac = value;

        /// <summary>
        /// <para> !DIMLIM! </para>
        /// <para> Example: false </para>
        /// <para> Generates dimension limits as the default text. </para>

        /// <para> Setting DIMLIM to On turns DIMTOL off. </para>

        /// <para> Value	Description </para>
        /// <para> false		Dimension limits are not generated as default text </para>
        /// <para> true		Dimension limits are generated as default text </para>
        /// </summary>
        public static bool SetDimlim(this Dimension rd, bool value) => rd.Dimlim = value;

        /// <summary>
        /// <para> !DIMLTEX1! </para>
        /// <para> Example: "" </para>
        /// <para> Sets the linetype of the first extension line. </para>

        /// <para> The value is BYLAYER, BYBLOCK, or the name of a linetype.  </para>
        /// </summary>
        public static ObjectId SetDimltex1(this Dimension rd, string value) => rd.Dimltex1 = HostApplicationServices.WorkingDatabase.Search(value, TBType.LineType);

        /// <summary>
        /// <para> !DIMLTEX2! </para>
        /// <para> Example: "" </para>
        /// <para> Sets the linetype of the second extension line. </para>

        /// <para> The value is BYLAYER, BYBLOCK, or the name of a linetype.  </para>
        /// </summary>
        public static ObjectId SetDimltex2(this Dimension rd, string value) => rd.Dimltex2 = HostApplicationServices.WorkingDatabase.Search(value, TBType.LineType);

        /// <summary>
        /// <para> !DIMLTYPE! </para>
        /// <para> Example: "" </para>
        /// <para> Sets the linetype of the dimension line. </para>

        /// <para> The value is BYLAYER, BYBLOCK, or the name of a linetype.  </para>
        /// </summary>
        public static ObjectId SetDimltype(this Dimension rd, string value) => rd.Dimltype = HostApplicationServices.WorkingDatabase.Search(value, TBType.LineType);

        /// <summary>
        /// <para> !DIMLUNIT! </para>
        /// <para> Example: 2 </para>
        /// <para> Sets units for all dimension types except Angular. </para>

        /// <para> Value	Description </para>
        /// <para> 1		Scientific </para>
        /// <para> 2		Decimal </para>
        /// <para> 3		Engineering </para>
        /// <para> 4		Architectural (always displayed stacked) </para>
        /// <para> 5		Fractional (always displayed stacked) </para>
        /// <para> 6		Microsoft Windows Desktop (decimal format using Control Panel settings for decimal separator and number grouping symbols) </para>
        /// </summary>
        public static int SetDimlinearUnits(this Dimension rd, int value) => rd.Dimlunit = value;

        /// <summary>
        /// <para> !DIMLWD! </para>
        /// <para> Example: -2 </para>
        /// <para> Assigns lineweight to dimension lines. </para>

        /// <para> Value	Description </para>
        /// <para> -1		Sets the lineweight to "BYLAYER." </para>
        /// <para> -2		Sets the lineweight to "BYBLOCK." </para>
        /// <para> -3		Sets the lineweight to "DEFAULT." "DEFAULT" is controlled by the LWDEFAULT system variable. </para>

        /// <para> Other valid values entered in hundredths of millimeters include 0, 5, 9, 13, 15, 18, 20, 25, 30, 35, 40, 50, 53, 60, 70, 80, 90, 100, 106, 120, 140, 158, 200, and 211. </para>

        /// <para> All values must be entered in hundredths of millimeters. (Multiply a value by 2540 to convert values from inches to hundredths of millimeters.)  </para>
        /// </summary>
        public static LineWeight SetDimlwd(this Dimension rd, LineWeight value) => rd.Dimlwd = value;

        /// <summary>
        /// <para> !DIMLWE! </para>
        /// <para> Example: -2 </para>
        /// <para> Assigns lineweight to extension lines. </para>

        /// <para> Value	Description </para>
        /// <para> -1		Sets the lineweight to "BYLAYER." </para>
        /// <para> -2		Sets the lineweight to "BYBLOCK." </para>
        /// <para> -3		Sets the lineweight to "DEFAULT." "DEFAULT" is controlled by the LWDEFAULT system variable. </para>

        /// <para> Other valid values entered in hundredths of millimeters include 0, 5, 9, 13, 15, 18, 20, 25, 30, 35, 40, 50, 53, 60, 70, 80, 90, 100, 106, 120, 140, 158, 200, and 211. </para>

        /// <para> All values must be entered in hundredths of millimeters. (Multiply a value by 2540 to convert values from inches to hundredths of millimeters.)  </para>
        /// </summary>
        public static Enum SetDimlwe(this Dimension rd, LineWeight value) => rd.Dimlwe = value;

        /// <summary>
        /// <para> !DIMPOST! </para>
        /// <para> Example: None </para>
        /// <para> Specifies a text prefix or suffix (or both) to the dimension measurement. </para>

        /// <para> For example, to establish a suffix for millimeters, set DIMPOST to mm; a distance of 19.2 units would be displayed as 19.2 mm. </para>

        /// <para> If tolerances are turned on, the suffix is applied to the tolerances as well as to the main dimension. </para>

        /// <para> Use <> to indicate placement of the text in relation to the dimension value. For example, enter <>mm to display a 5.0 millimeter radial dimension as "5.0mm". If you entered mm <>, the dimension would be displayed as "mm 5.0". Use the <> mechanism for angular dimensions.  </para>
        /// </summary>
        public static string SetDimpost(this Dimension rd, string value) => rd.Dimpost = value;

        /// <summary>
        /// <para> !DIMRND! </para>
        /// <para> Example: 0.0000 </para>
        /// <para> Rounds all dimensioning distances to the specified value. </para>
        /// <para> For instance, if DIMRND is set to 0.25, all distances round to the nearest 0.25 unit. If you set DIMRND to 1.0, all distances round to the nearest integer. Note that the number of digits edited after the decimal point depends on the precision set by DIMDEC. DIMRND does not apply to angular dimensions.  </para>
        /// </summary>
        public static double SetDimRound(this Dimension rd, double value) => rd.Dimrnd = value;

        /// <summary>
        /// <para> !DIMSAH! </para>
        /// <para> Example: false </para>
        /// <para> Controls the display of dimension line arrowhead blocks. </para>
        /// <para> Value	Description </para>
        /// <para> false    Use arrowhead blocks set by DIMBLK </para>
        /// <para> true		Use arrowhead blocks set by DIMBLK1 and DIMBLK2 </para>
        /// </summary>
        public static bool SetDimsah(this Dimension rd, bool value) => rd.Dimsah = value;

        /// <summary>
        /// <para> !DIMSCALE! </para>
        /// <para> Example: 1.0000 </para>
        /// <para> Sets the overall scale factor applied to dimensioning variables that specify sizes, distances, or offsets. </para>

        /// <para> Also affects the leader objects with the LEADER command. </para>

        /// <para> Use MLEADERSCALE to scale multileader objects created with the MLEADER command. </para>

        /// <para> Value	Description </para>
        /// <para> 0.0		A reasonable default value is computed based on the scaling between the current model space viewport and paper space. If you are in paper space or model space and not using the paper space feature, the scale factor is 1.0. </para>
        /// <para> >0		A scale factor is computed that leads text sizes, arrowhead sizes, and other scaled distances to plot at their face values. </para>

        /// <para> DIMSCALE does not affect measured lengths, coordinates, or angles. </para>

        /// <para> Use DIMSCALE to control the overall scale of dimensions. However, if the current dimension style is annotative, DIMSCALE is automatically set to zero and the dimension scale is controlled by the CANNOSCALE system variable. DIMSCALE cannot be set to a non-zero value when using annotative dimensions.  </para>
        /// </summary>
        public static double SetDimScale(this Dimension rd, double value) => rd.Dimscale = value;

        /// <summary>
        /// <para> !DIMSD1! </para>
        /// <para> Example: false </para>
        /// <para> Controls suppression of the first dimension line and arrowhead. </para>

        /// <para> When turned on, suppresses the display of the dimension line and arrowhead between the first extension line and the text. </para>

        /// <para> Value	Description </para>
        /// <para> false	First dimension line is not suppressed </para>
        /// <para> true		First dimension line is suppressed </para>
        /// </summary>
        public static bool SetSuppressesDimension1(this Dimension rd, bool value) => rd.Dimsd1 = value;

        /// <summary>
        /// <para> !DIMSD2! </para>
        /// <para> Example: false </para>
        /// <para> Controls suppression of the second dimension line and arrowhead. </para>

        /// <para> When turned on, suppresses the display of the dimension line and arrowhead between the second extension line and the text. </para>

        /// <para> Value	Description </para>
        /// <para> false		Second dimension line is not suppressed </para>
        /// <para> true		Second dimension line is suppressed </para>
        /// </summary>
        public static bool SetSuppressesDimension2(this Dimension rd, bool value) => rd.Dimsd2 = value;

        /// <summary>
        /// <para> !DIMSE! </para>
        /// <para> Example: false </para>
        /// <para> Suppresses display of the first extension line. </para>

        /// <para> Value	Description </para>
        /// <para> false		Extension line is not suppressed </para>
        /// <para> true		Extension line is suppressed </para>
        /// </summary>
        public static bool SetSuppressesExtension1(this Dimension rd, bool value) => rd.Dimse1 = value;

        /// <summary>
        /// <para> !DIMSE! </para>
        /// <para> Example: false </para>
        /// <para> Suppresses display of the second extension line. </para>
        /// <para> Value	Description </para>
        /// <para> false	Extension line is not suppressed </para>
        /// <para> true		Extension line is suppressed </para>
        /// </summary>
        public static bool SetSuppressesExtension2(this Dimension rd, bool value) => rd.Dimse2 = value;

        /// <summary>
        /// <para> !DIMSOXD! </para>
        /// <para> Example: false </para>
        /// <para> Suppresses arrowheads if not enough space is available inside the extension lines. </para>
        /// <para> Value	Description </para>
        /// <para> false	Arrowheads are not suppressed </para>
        /// <para> true		Arrowheads are suppressed </para>
        /// <para> If not enough space is available inside the extension lines and DIMTIX is on, setting DIMSOXD to On suppresses the arrowheads. If DIMTIX is off, DIMSOXD has no effect.  </para>
        /// </summary>
        public static void SetDimsoxd(this Dimension rd, bool value) => rd.Dimsoxd = value;

        public enum DimTextVerticalMode
        { Center, Above, Side, JIS, Below }

        /// <summary>
        /// <para> !DIMTAD! </para>
        /// <para> Example: 0 (imperial) or 1 (metric) </para>
        /// <para> Controls the vertical position of text in relation to the dimension line. </para>
        /// <para> Value	            Description </para>
        /// <para> Center   =   0		Centers the dimension text between the extension lines. </para>
        /// <para> Above    =   1		Places the dimension text above the dimension line except when the dimension line is not horizontal and text inside the extension lines is forced horizontal ( DIMTIH = 1).</para>
        /// <para>              		The distance from the dimension line to the baseline of the lowest line of text is the current DIMGAP value. </para>
        /// <para> Side     =   2		Places the dimension text on the side of the dimension line farthest away from the defining points. </para>
        /// <para> JIS      =   3		Places the dimension text to conform to Japanese Industrial Standards (JIS). </para>
        /// <para> Below    =   4		Places the dimension text below the dimension line. </para>
        /// </summary>
        public static void SetVerticalMode(this Dimension rd, DimTextVerticalMode value) => rd.Dimtad = (int)value;

        /// <summary>
        /// Dimtad=1
        /// </summary>
        /// <param name="rd"></param>
        public static void SetTextAbove(this Dimension rd) => rd.Dimtad = 1;

        /// <summary>
        /// Dimtad=4
        /// </summary>
        /// <param name="rd"></param>
        public static void SetTextBelow(this Dimension rd) => rd.Dimtad = 4;

        /// <summary>
        /// <para> !DIMTDEC! </para>
        /// <para> Example: 4 (imperial) or 2 (metric) </para>
        /// <para> Sets the number of decimal places to display in tolerance values for the primary units in a dimension. </para>

        /// <para> This system variable has no effect unless DIMTOL is set to On. The default for DIMTOL is Off.  </para>
        /// </summary>
        public static void SetDecimalTolerance(this Dimension rd, int value) => rd.Dimtdec = value;

        /// <summary>
        /// <para> !DIMTFAC! </para>
        /// <para> Example: 1.0000 </para>
        /// <para> Specifies a scale factor for the text height of fractions and tolerance values relative to the dimension text height, as set by DIMTXT. </para>

        /// <para> For example, if DIMTFAC is set to 1.0, the text height of fractions and tolerances is the same height as the dimension text. If DIMTFAC is set to 0.7500, the text height of fractions and tolerances is three-quarters the size of dimension text.  </para>
        /// </summary>
        public static void SetTextFactor(this Dimension rd, double value) => rd.Dimtfac = value;

        /// <summary>
        /// <para> !DIMTFILL! </para>
        /// <para> Example: 0 </para>
        /// <para> Controls the background of dimension text. </para>

        /// <para> Value	Description </para>
        /// <para> 0		No background </para>
        /// <para> 1		The background color of the drawing </para>
        /// <para> 2		The background specified by DIMTFILLCLR </para>
        /// </summary>
        public static int SetTextBackgroundFill(this Dimension rd, int value) => rd.Dimtfill = value;

        /// <summary>
        /// <para> !DIMTFILLCLR! </para>
        /// <para> Example: 0 </para>
        /// <para> Sets the color for the text background in dimensions. </para>

        /// <para> Color numbers are displayed in the Select Color dialog box. For BYBLOCK, enter 0. For BYLAYER, enter 256.  </para>
        /// </summary>
        public static void SetTextBackgroundColor(this Dimension rd, int value) => rd.Dimtfillclr = Color.FromColorIndex(ColorMethod.ByAci, (short)value);

        /// <summary>
        /// <para> !DIMTIH! </para>
        /// <para> Example: true (imperial) or false (metric) </para>
        /// <para> Controls the position of dimension text inside the extension lines for all dimension types except Ordinate. </para>
        /// <para> Value	Description </para>
        /// <para> false	Aligns text with the dimension line </para>
        /// <para> true		Draws text horizontally </para>
        /// </summary>
        public static bool SetDimtih(this Dimension rd, bool value) => rd.Dimtih = value;

        /// <summary>
        /// <para> !DIMTIX! </para>
        /// <para> Example: false </para>
        /// <para> Draws text between extension lines. </para>
        /// <para> Value	Description </para>
        /// <para> false	For linear and angular dimensions, dimension text is placed inside the extension lines if there is sufficient room. </para>
        /// <para> true		Draws dimension text between the extension lines even if it would ordinarily be placed outside those lines.</para>
        /// <para> true		For radius and diameter dimensions, DIMTIX on always forces the dimension text outside the circle or arc. </para>
        /// </summary>
        public static bool SetTextInside(this Dimension rd, bool value) => rd.Dimtix = value;

        public static bool SetDimtix(this Dimension rd, bool value) => rd.Dimtix = value;

        /// <summary>
        /// <para> !DIMTM! </para>
        /// <para> Example: 0.0000 </para>
        /// <para> Sets the minimum (or lower) tolerance limit for dimension text when DIMTOL or DIMLIM is on. </para>
        /// <para> DIMTM accepts signed values. If DIMTOL is on and DIMTP and DIMTM are set to the same value, a tolerance value is drawn. </para>
        /// <para> If DIMTM and DIMTP values differ, the upper tolerance is drawn above the lower, and a plus sign is added to the DIMTP value if it is positive. </para>
        /// <para> For DIMTM, the program uses the negative of the value you enter (adding a minus sign if you specify a positive number and a plus sign if you specify a negative number).  </para>
        /// </summary>
        public static double SetDimtm(this Dimension rd, double value) => rd.Dimtm = value;

        /// <summary>
        /// <para> !DIMTMOVE! </para>
        /// <para> Example: 0 </para>
        /// <para> Sets dimension text movement rules. </para>
        /// <para> Value	Description </para>
        /// <para> 0		Moves the dimension line with dimension text </para>
        /// <para> 1		Adds a leader when dimension text is moved </para>
        /// <para> 2		Allows text to be moved freely without a leader </para>
        /// </summary>
        public static int SetTextMove(this Dimension rd, int value) => rd.Dimtmove = value;

        /// <summary>
        /// <para> !DIMTOFL! </para>
        /// <para> Example: false (imperial) or true (metric) </para>
        /// <para> Controls whether a dimension line is drawn between the extension lines even when the text is placed outside. </para>
        /// <para> For radius and diameter dimensions, a dimension line is drawn inside the circle or arc when the text, arrowheads, and leader are placed outside. </para>
        /// <para> Value	Description </para>
        /// <para> false	Does not draw dimension lines between the measured points when arrowheads are placed outside the measured points </para>
        /// <para> true		Draws dimension lines between the measured points even when arrowheads are placed outside the measured points </para>
        /// </summary>
        public static bool SetDimmensionLineIs(this Dimension rd, bool value) => rd.Dimtofl = value;

        /// <summary>
        /// <para> !DIMTOH! </para>
        /// <para> Example: true (imperial) or false (metric) </para>
        /// <para> Controls the position of dimension text outside the extension lines. </para>
        /// <para> Value	Description </para>
        /// <para> false	Aligns text with the dimension line </para>
        /// <para> true		Draws text horizontally </para>
        /// </summary>
        public static bool SetDimtoh(this Dimension rd, bool value) => rd.Dimtoh = value;

        /// <summary>
        /// <para> !DIMTOL! </para>
        /// <para> Example: Off </para>
        /// <para> Appends tolerances to dimension text. </para>
        /// <para> Setting DIMTOL to on turns DIMLIM off.  </para>
        /// </summary>
        public static bool SetDimtol(this Dimension rd, bool value) => rd.Dimtol = value;

        /// <summary>
        /// <para> !DIMTOLJ! </para>
        /// <para> Example: 1 (imperial) or 0 (metric) </para>
        /// <para> Sets the vertical justification for tolerance values relative to the nominal dimension text. </para>

        /// <para> This system variable has no effect unless DIMTOL is set to On. The default for DIMTOL is Off. </para>

        /// <para> Value	Description </para>
        /// <para> 0		Bottom </para>
        /// <para> 1		Middle </para>
        /// <para> 2		Top </para>
        /// </summary>
        public static int SetDimtolj(this Dimension rd, int value) => rd.Dimtolj = value;

        /// <summary>
        /// <para> !DIMTP! </para>
        /// <para> Example: 0.0000 </para>
        /// <para> Sets the maximum (or upper) tolerance limit for dimension text when DIMTOL or DIMLIM is on. </para>

        /// <para> DIMTP accepts signed values. If DIMTOL is on and DIMTP and DIMTM are set to the same value, a tolerance value is drawn. </para>

        /// <para> If DIMTM and DIMTP values differ, the upper tolerance is drawn above the lower and a plus sign is added to the DIMTP value if it is positive.  </para>
        /// </summary>
        public static double SetDimtp(this Dimension rd, double value) => rd.Dimtp = value;

        /// <summary>
        /// <para> !DIMTSZ! </para>
        /// <para> Example: 0.0000 </para>
        /// <para> Specifies the size of oblique strokes drawn instead of arrowheads for linear, radius, and diameter dimensioning. </para>
        /// <para> Value	Description </para>
        /// <para> 0		Draws arrowheads. </para>
        /// <para> >0		Draws oblique strokes instead of arrowheads. The size of the oblique strokes is determined by this value multiplied by the DIMSCALE value. </para>
        /// </summary>
        public static double SetDimtsz(this Dimension rd, double value) => rd.Dimtsz = value;

        /// <summary>
        /// <para> !DIMTVP! </para>
        /// <para> Example: 0.0000 </para>
        /// <para> Controls the vertical position of dimension text above or below the dimension line. </para>
        /// <para> The DIMTVP value is used when DIMTAD is off. The magnitude of the vertical offset of text is the product of the text height and DIMTVP. Setting DIMTVP to 1.0 is equivalent to setting DIMTAD to on. The dimension line splits to accommodate the text only if the absolute value of DIMTVP is less than 0.7.  </para>
        /// </summary>
        public static double SetDimtvp(this Dimension rd, double value) => rd.Dimtvp = value;

        /// <summary>
        /// <para> !DIMTXSTY! </para>
        /// <para> Example: Standard </para>
        /// <para> Specifies the text style of the dimension. </para>
        /// </summary>
        //public static string SetDimtxsty(this Dimension rd, string value) => rd.SetDimtxsty = value;

        /// <summary>
        /// <para> !DIMTXT! </para>
        /// <para> Example: 0.1800 (imperial) or 2.5000 (metric) </para>
        /// <para> Specifies the height of dimension text, unless the current text style has a fixed height. </para>
        /// </summary>
        public static double SetTextSize(this Dimension rd, double value) => rd.Dimtxt = value;

        /// <summary>
        /// <para> !DIMTXTDIRECTION! </para>
        /// <para> Example: 0 </para>
        /// <para> Specifies the reading direction of the dimension text. </para>

        /// <para> Value	Description </para>
        /// <para> 0		Displays dimension text in a Left-to-Right reading style </para>
        /// <para> 1		Displays dimension text in a Right-to-Left reading style </para>
        /// </summary>
        public static bool SetDimTextDirection(this Dimension rd, bool value) => rd.Dimtxtdirection = value;

        /// <summary>
        /// <para> !DIMTZIN! </para>
        /// <para> Example: 0 (imperial) or 8 (metric) </para>
        /// <para> Controls the suppression of zeros in tolerance values. </para>
        /// <para> Values 0-3 affect feet-and-inch dimensions only. </para>
        /// <para> Value	Description </para>
        /// <para> 0		Suppresses zero feet and precisely zero inches </para>
        /// <para> 1		Includes zero feet and precisely zero inches </para>
        /// <para> 2		Includes zero feet and suppresses zero inches </para>
        /// <para> 3		Includes zero inches and suppresses zero feet </para>
        /// <para> 4		Suppresses leading zeros in decimal dimensions (for example, 0.5000 becomes .5000) </para>
        /// <para> 8		Suppresses trailing zeros in decimal dimensions (for example, 12.5000 becomes 12.5) </para>
        /// <para> 12		Suppresses both leading and trailing zeros (for example, 0.5000 becomes .5) </para>
        /// </summary>
        public static int SetDimtzin(this Dimension rd, int value) => rd.Dimtzin = value;

        /// <summary>
        /// <para> !DIMUPT! </para>
        /// <para> Example: false </para>
        /// <para> Controls options for user-positioned text. </para>
        /// <para> Value	Description </para>
        /// <para> false	Cursor controls only the dimension line location </para>
        /// <para> true		Cursor controls both the text position and the dimension line location </para>
        /// </summary>
        public static bool SetDimupt(this Dimension rd, bool value) => rd.Dimupt = value;

        /// <summary>
        /// <para> !DIMZIN! </para>
        /// <para> Example: 0 (imperial) or 8 (metric) </para>
        /// <para> Controls the suppression of zeros in the primary unit value. </para>
        /// <para> Values 0-3 affect feet-and-inch dimensions only: </para>
        /// <para> Value	Description </para>
        /// <para> 0		Suppresses zero feet and precisely zero inches </para>
        /// <para> 1		Includes zero feet and precisely zero inches </para>
        /// <para> 2		Includes zero feet and suppresses zero inches </para>
        /// <para> 3		Includes zero inches and suppresses zero feet </para>
        /// <para> 4		Suppresses leading zeros in decimal dimensions (for example, 0.5000 becomes .5000) </para>
        /// <para> 8		Suppresses trailing zeros in decimal dimensions (for example, 12.5000 becomes 12.5) </para>
        /// <para> 12		Suppresses both leading and trailing zeros (for example, 0.5000 becomes .5) </para>
        /// <para> DIMZIN also affects real-to-string conversions performed by the AutoLISP rtos and angtos functions.  </para>
        /// </summary>
        public static int SetDimzin(this Dimension rd, int value) => rd.Dimzin = value;
    }
}