using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nLibary
{
	public static class cMessage
	{
		static int _fontSize = 16;
		static string _message = "Message";
        #region ShowMessage
        public static void ShowMessage(string message)
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);
            cFlexibleMessageBox.Show(message, _message, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Exit
        /// <summary>
        /// Message = คุณต้องการออกจากโปรแกรม
        /// </summary>
        /// <returns></returns>        
        public static void Exit()
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);

            var result = cFlexibleMessageBox.Show("คุณต้องการออกจากโปรแกรม.",
                                                 _message,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question,
                                                 MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
        #endregion

        #region System Closed
        /// <summary>
        /// Message = คุณต้องการออกจากโปรแกรม
        /// </summary>
        /// <returns></returns>        
        public static void SystemClosed()
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);

            cFlexibleMessageBox.Show("ไม่สามารถใช้งานระบบได้ เนื่องจากระบบปิดการทำงานอยู่."
                , _message, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region POS_Electronics_Abb
        /// <summary>
        /// Message = สามารถตรวจบิลขายได้ใน kBeauty Mobile
        /// </summary>
        /// <returns></returns>
        public static void POS_Electronics_Abb()
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);
            cFlexibleMessageBox.Show("สามารถตรวจบิลขายได้ใน kBeauty Mobile", _message, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Complete_SaveHoldData
        /// <summary>
        /// Message = พักบิลขายสำเร็จ
        /// </summary>
        /// <returns></returns>
        public static void Complete_SaveHoldData()
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);
            cFlexibleMessageBox.Show("พักบิลขายสำเร็จ", _message, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Complete_SaveData
        /// <summary>
        /// Message = บันทึกข้อมูลสำเร็จ
        /// </summary>
        /// <returns></returns>
        public static void Complete_SaveData()
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);
            cFlexibleMessageBox.Show("บันทึกข้อมูลสำเร็จ", _message, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Complete_CheckData
        /// <summary>
        /// Message = ตรวจสอบข้อมูลถูกต้อง
        /// </summary>
        /// <returns></returns>
        public static void Complete_CheckData()
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);
            cFlexibleMessageBox.Show("ตรวจสอบข้อมูลถูกต้อง", _message, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Complete_CancelAbb
        /// <summary>
        /// Message = บันทึกข้อมูลสำเร็จ
        /// </summary>
        /// <returns></returns>
        public static void Complete_CancelAbb()
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);
            cFlexibleMessageBox.Show("ยกเลิกบิลขายสำเร็จ", _message, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Complete_GetData
        /// <summary>
        /// Message = โหลดข้อมูลสำเร็จ
        /// </summary>
        /// <returns></returns>
        public static void Complete_GetData()
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);
            cFlexibleMessageBox.Show("โหลดข้อมูลสำเร็จ", _message, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Complete_PrintData
        /// <summary>
        /// Message = พิมพ์ข้อมูลสำเร็จ
        /// </summary>
        /// <returns></returns>
        public static void Complete_PrintData()
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);
            cFlexibleMessageBox.Show("พิมพ์ข้อมูลสำเร็จ", _message, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Complete_RecalData
        /// <summary>
        /// Message = ประมวลผลข้อมูลสำเร็จ
        /// </summary>
        /// <returns></returns>
        public static void Complete_RecalData()
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);
            cFlexibleMessageBox.Show("ประมวลผลข้อมูลสำเร็จ", _message, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Import_Complete
        /// <summary>
        /// Message = นำเข้าข้อมูลสำเร็จ
        /// </summary>
        /// <returns></returns>
        public static void Import_Complete()
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);
            cFlexibleMessageBox.Show("นำเข้าข้อมูลสำเร็จ", _message, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Export_Complete
        public static void Export_Complete()
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);
            cFlexibleMessageBox.Show("ส่งออกข้อมูลข้อมูลสำเร็จ", _message, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Error_Duplicate_Data
        /// <summary>
        /// Message = ข้อมูลมีอยู่แล้วในระบบ กรุณาตรวจสอบอีกครั้ง
        /// </summary>
        /// <returns></returns>
        public static void Error_Duplicate_Data()
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);
            cFlexibleMessageBox.Show("ข้อมูลมีอยู่แล้วในระบบ กรุณาตรวจสอบอีกครั้ง", _message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Error_NotCaption
        public static void Error_NotCaption(string message)
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", 18, FontStyle.Regular);
            cFlexibleMessageBox.Show(message, _message, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        #endregion

        #region Error_NoData
        /// <summary>
        /// Message = ไม่พบข้อมูล
        /// </summary>
        /// <returns></returns>
        public static void Error_NoData()
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);
            cFlexibleMessageBox.Show("ไม่พบข้อมูล", _message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Error_OnProcess
        /// <summary>
        /// Message = ไม่สามารถทำงานได้เนืองจากมีการขายอยู่
        /// </summary>
        /// <returns></returns>
        public static void Error_OnProcess()
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);
            cFlexibleMessageBox.Show("ไม่สามารถทำงานได้เนืองจากมีการขายอยู่", _message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Error_Printer
        /// <summary>
        /// Message = เครื่องพิมพ์ไม่พร้อมใช้งาน
        /// </summary>
        /// <returns></returns>
        public static void Error_Printer()
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);
            cFlexibleMessageBox.Show("เครื่องพิมพ์ไม่พร้อมใช้งาน", _message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Error_Login
        /// <summary>
        /// Message = ไม่สามารถเข้าใช้งานได้
        /// </summary>
        /// <returns></returns>
        public static void Error_Login()
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);
            cFlexibleMessageBox.Show("ไม่สามารถเข้าใช้งานได้", _message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Error_InvalidPaymentSelect
        /// <summary>
        /// Message = ไม่สามารถใช้งานได้ เนื่องจากยังไม่มีรายการขาย
        /// </summary>
        /// <returns></returns>
        public static void Error_InvalidPaymentSelect()
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);
            cFlexibleMessageBox.Show("ไม่สามารถใช้งานได้ เนื่องจากยังไม่มีรายการขาย", _message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Error_InvalidData
        /// <summary>
        /// Message = กรุณาระบุข้อมูลให้ถูกต้อง
        /// </summary>
        /// <returns></returns>
        public static void Error_InvalidData()
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);
            cFlexibleMessageBox.Show("กรุณาระบุข้อมูลให้ถูกต้อง", _message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Error_InvalidPayment
        /// <summary>
        /// Message = ใส่จำนวนเงินไม่ถูกต้อง
        /// </summary>
        /// <returns></returns>
        public static void Error_InvalidPayment()
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);
            cFlexibleMessageBox.Show("ใส่จำนวนเงินไม่ถูกต้อง", _message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion


        #region Error_Running_Data
        /// <summary>
        /// Message = หมายเลข Running ซ้ำระบบจะทำการสร้างใหม่ กรุณาตรวจสอบและบันทึกอีกครั้ง
        /// </summary>
        /// <returns></returns>
        public static void Error_Running_Data()
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);
            cFlexibleMessageBox.Show("หมายเลข Running ซ้ำระบบจะทำการสร้างใหม่ กรุณาตรวจสอบและบันทึกอีกครั้ง", _message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Error_POS_NotReturn
        /// <summary>
        /// Message = ไม่สามารถรับคืนได้ โปรดตรวจสอบข้อมูลอีกครั้ง
        /// </summary>
        /// <returns></returns>
        public static void Error_POS_NotReturn()
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);
            cFlexibleMessageBox.Show("ไม่สามารถรับคืนได้ โปรดตรวจสอบข้อมูลอีกครั้ง", _message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Error_Customer_BirthDay
        /// <summary>
        /// Message = ไม่พบข้อมูลวันเกิดของสมาชิก
        /// </summary>
        /// <returns></returns>
        public static void Error_Customer_BirthDay()
        {
            cFlexibleMessageBox.FONT = new Font("Tahoma", _fontSize, FontStyle.Regular);
            cFlexibleMessageBox.Show("ไม่พบข้อมูลวันเกิดของสมาชิก", _message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
    }
}
