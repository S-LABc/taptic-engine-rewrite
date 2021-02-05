using Apple_Taptic_Engine_Rewrite.Properties;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Globalization;
using System.IO.Ports;
using System.Windows.Forms;

/**
 * Apple Taptic Engine Rewrite
 * 
 * Приложение формирует и отправляет в serial port пакет из байт серийного номера Taptic Engine
 * 
 * Copyright (C) 2020. v1.0 / Скляр Роман S-LAB
 * YouTube https://www.youtube.com/channel/UCbkE52YKRphgkvQtdwzQbZQ
 * BUILD IN Microsoft Visual Studio Professional 2019 v16.4.3
 * .NET framework 4.6
 * 
*/

namespace Apple_Taptic_Engine_Rewrite
{
    public partial class TapticEngineRewrite : MetroForm
    {
        public TapticEngineRewrite()
        {
            InitializeComponent();
            //Настройка порта связи
            PortPreparation();
            //Загрузка настроек
            ElemetsDefaultValue();
        }

        //Подготовка и автовыбор порта в списке
        private void PortPreparation()
        {
            //Заполнение массива найденными портами
            string[] ports = SerialPort.GetPortNames();
            //Очистка и заполнение списка
            cbPort.Items.Clear();
            cbPort.Items.AddRange(ports);
            //Если есть хоть один порт - выбрать его, иначе пустое поле
            cbPort.SelectedIndex = (ports.Length != 0) ? 0 : -1;
            //Доступность кнопки
            ButtonCheck();
        }

        //Проверка кнопки
        private void ButtonCheck()
        {
            //Если список портов пуст или символов меньше
            if (cbPort.Text == string.Empty ||
                tbTapticEngineSN.Text.Length < Convert.ToInt32(Resources.LIMIT_TAPTIC_ENGINE))
            {
                btnWrite.Enabled = false;
            }
            else
            {
                btnWrite.Enabled = true;
            }
        }

        //Применение основных настроек для программы
        private void ElemetsDefaultValue()
        {
            //Добавление моделей аппаратов
            cbModelType.Items.AddRange(new object[] {
            Resources.TEXT_7_7P,
            Resources.TEXT_8_8P_X_XR});
            //Вывести число символов в полесерийника TAPTIC ENGINE
            lblNumTESN.Text = string.Format(Resources.FORMAT_LABLE + Resources.LIMIT_TAPTIC_ENGINE, tbTapticEngineSN.Text.Length.ToString(CultureInfo.InvariantCulture));
            //Установить ограничение на количетсво символов TAPTIC ENGINE
            tbTapticEngineSN.MaxLength = Convert.ToInt32(Resources.LIMIT_TAPTIC_ENGINE);
            //Вывод последнего значения TAPTIC ENGINE
            tbTapticEngineSN.Text = Settings.Default.LAST_VALUE;
            //Выбор последней модели выбранной пользователем
            cbModelType.Text = Settings.Default.MODEL_TYPE;
            //Установка скорости связи
            spTAPTIC.BaudRate = Settings.Default.SERIAL_BAUDRATE;
            //Установка значка приложения
            Icon = Resources.TapticEngineRewrite;
        }

        //Сохранение изменений
        private void SaveChanges()
        {
            //Переписать новый серийник TAPTIC ENGINE
            Settings.Default.LAST_VALUE = tbTapticEngineSN.Text;
            //Переписать новое значение выбранной модели
            Settings.Default.MODEL_TYPE = cbModelType.Text;
            //Сохранить новые настройки
            Settings.Default.Save();
        }

        //Формирование пакета данных для отправления в плату
        private string DataPrepare()
        {
            string data = tbTapticEngineSN.Text;

            if (cbModelType.Text == Resources.TEXT_7_7P)
            {
                data += Settings.Default.KEY_7_7P; //xxxxxxxxxxxxxxxxx+yyyyyA
            }
            else if (cbModelType.Text == Resources.TEXT_8_8P_X_XR)
            {
                data += Settings.Default.KEY_8_8P_X_XR; //xxxxxxxxxxxxxxxxx+yyyyyB
            }
            
            return data;
        }

        //Перед закрытием сохранить поля сериника и модели
        private void TapticEngineRewrite_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveChanges();
        }

        //Прри редактирования поля серийника TAPTIC ENGINE
        private void tbTapticEngineSN_TextChanged(object sender, EventArgs e)
        {
            //Вывести число символов в поле
            lblNumTESN.Text = string.Format(Resources.FORMAT_LABLE + Resources.LIMIT_TAPTIC_ENGINE, tbTapticEngineSN.Text.Length.ToString(CultureInfo.InvariantCulture));
            ButtonCheck();
        }

        //Обновление списка портов кликом по списку
        private void cbPort_MouseClick(object sender, MouseEventArgs e)
        {
            PortPreparation();
        }

        //Запись серийника в память TAPTIC ENGINE
        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                //Выбор порта
                spTAPTIC.PortName = Convert.ToString(cbPort.Text);
                //Открыть соединение
                spTAPTIC.Open();
                //Отправка данных
                spTAPTIC.Write(DataPrepare());
                spTAPTIC.Close();
            }
            catch
            {
                spTAPTIC.Close();
                //Сообщение об ошибке связи
                MetroMessageBox.Show(this,
                    Messages.ERROR_RELATION,
                    Messages.ERROR,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
