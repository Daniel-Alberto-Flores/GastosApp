using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class TranslateToSpanish
    {
        // Method used to translate to spanish

        public string FormFilter(string formName, string Type, string Filter)
        {
            string Message = "";
            // We use this method to filter form and control/message
            if ((formName == "frmMain") && (Type == "Control"))
                Message = FrmMainControlsTraduction(Filter);
            if ((formName == "frmMain") && (Type == "Message"))
                Message = FrmMainMessageTraduction(Filter);

            if ((formName == "frmIncomes") && (Type == "Control"))
                Message = FrmIncomesControlsTraduction(Filter);
            if ((formName == "frmIncomes") && (Type == "Message"))
                Message = FrmIncomesMessageTraduction(Filter);

            if ((formName == "frmOutflows") && (Type == "Control"))
                Message = FrmOutflowsControlsTraduction(Filter);
            if ((formName == "frmOutflows") && (Type == "Message"))
                Message = FrmOutflowsMessageTraduction(Filter);

            if ((formName == "frmOutflowsPreload") && (Type == "Control"))
                Message = FrmOutflowsPreloadControlsTraduction(Filter);
            if ((formName == "frmOutflowsPreload") && (Type == "Message"))
                Message = FrmOutflowsPreloadMessageTraduction(Filter);

            if ((formName == "frmNotes") && (Type == "Control"))
                Message = FrmNotesControlsTraduction(Filter);
            if ((formName == "frmNotes") && (Type == "Message"))
                Message = FrmNotesMessageTraduction(Filter);

            if ((formName == "frmHelp") && (Type == "Control"))
                Message = FrmHelpControlsTraduction(Filter);

            if ((formName == "frmAbout") && (Type == "Control"))
                Message = FrmAboutControlsTraduction(Filter);

            return Message;
        }

        // frmMain Controls => We use this methods to filter control or message
        public string FrmMainControlsTraduction(string Filter)
        {
            string translatedText = "";
            switch (Filter)
            {
                case "btnOutflows":
                    translatedText = "Egresos";
                    break;
                case "btnIncomes":
                    translatedText = "Ingresos";
                    break;
                case "btnNotes":
                    translatedText = "Notas";
                    break;
                case "btnHelp":
                    translatedText = "Ayuda";
                    break;
                case "btnAbout":
                    translatedText = "Acerca de";
                    break;
                case "lblLanguage":
                    translatedText = "Idioma:";
                    break;
            }
            return translatedText;
        }

        // frmMain Messages => We use this methods to filter control or message
        public string FrmMainMessageTraduction(string Filter)
        {
            string translatedText = "";
            switch (Filter)
            {
                case "LanguageUpdated":
                    translatedText = "Idioma actualizado.";
                    break;
            }
            return translatedText;
        }

        // frmIncomes Controls => We use this methods to filter control or message
        public string FrmIncomesControlsTraduction(string Filter)
        {
            string translatedText = "";
            switch (Filter)
            {
                case "frmIncomes":
                    translatedText = "Ingresos";
                    break;
                case "btnReturn":
                    translatedText = "Volver";
                    break;
                case "gbxListInc":
                    translatedText = "Listado de ingresos";
                    break;
                case "gbxCalculatorInc":
                    translatedText = "Calculadora";
                    break;
                case "lblInc":
                    translatedText = "Ingreso:";
                    break;
                case "lblIncName":
                    translatedText = "Nombre";
                    break;
                case "lblIncAmount":
                    translatedText = "Monto ($):";
                    break;
                case "lblIncValue":
                    translatedText = "Valor";
                    break;
                case "gbxIncTypes":
                    translatedText = "Agregar tipos de ingresos";
                    break;
                case "lblIncTypeNewName":
                    translatedText = "Nombre:";
                    break;
                case "lblBalance":
                    translatedText = "Saldo ($):";
                    break;
            }
            return translatedText;
        }

        // frmIncomes Messages
        public string FrmIncomesMessageTraduction(string Filter)
        {
            string translatedText = "";
            switch (Filter)
            {
                case "BtnIncRemoveClick":
                    translatedText = "Eliminará los ingresos seleccionados para el periodo actual. ¿Está seguro? \nIngreso seleccionado:";
                    break;
                case "BtnIncRemoveNotExist":
                    translatedText = "No existe el movimiento para el período seleccionado.";
                    break;
                case "BtnIncSaveEnterAmount":
                    translatedText = "Debe ingresar un monto.";
                    break;
                case "BtnIncSaveWrongValue":
                    translatedText = "Valor de ingreso incorrecto.";
                    break;
                case "ExistingIncome":
                    translatedText = "El tipo seleccionado ya está cargado.";
                    break;
                case "BtnIncTypesRemoveClick":
                    translatedText = "Va a eliminar definitivamente el tipo de ingreso seleccionado ¿Está seguro? \nIngreso seleccionado:";
                    break;
                case "IncomeAlreadyLoaded":
                    translatedText = "El ingreso ingresado ya está cargado.";
                    break;
                case "CompleteFieldName":
                    translatedText = "Debe completar el campo 'Nombre'.";
                    break;
                case "LengthNameInvalid":
                    translatedText = "Solo se permiten ingresar hasta 14 carácteres para el campo nombre.";
                    break;
            }
            return translatedText;
        }

        // frmOutflows Controls => We use this methods to filter control or message
        public string FrmOutflowsControlsTraduction(string Filter)
        {
            string translatedText = "";
            switch (Filter)
            {
                case "frmOutflows":
                    translatedText = "Egresos";
                    break;
                case "btnReturn":
                    translatedText = "Volver";
                    break;
                case "gbxListOut":
                    translatedText = "Listado de egresos";
                    break;
                case "lblOutDaily":
                    translatedText = "Diarios:";
                    break;
                case "lblOutOthers":
                    translatedText = "Otros:";
                    break;
                case "gbxCalculatorOut":
                    translatedText = "Calculadora";
                    break;
                case "lblOut":
                    translatedText = "Egreso:";
                    break;
                case "lblOutName":
                    translatedText = "Nombre";
                    break;
                case "lblOutAmount":
                    translatedText = "Monto ($):";
                    break;
                case "lblOutValue":
                    translatedText = "Valor";
                    break;
                case "gbxOutTypes":
                    translatedText = "Agregar tipos de egresos";
                    break;
                case "lblOutTypeNewName":
                    translatedText = "Nombre:";
                    break;
                case "lblOutTypeDaily":
                    translatedText = "Diario:";
                    break;
                case "lblBalance":
                    translatedText = "Saldo ($):";
                    break;
            }
            return translatedText;
        }

        // frmOutflows Messages
        public string FrmOutflowsMessageTraduction(string Filter)
        {
            string translatedText = "";
            switch (Filter)
            {
                case "BtnOutRemoveClick":
                    translatedText = "Eliminará los egresos seleccionados para el periodo actual. ¿Está seguro? \nEgreso seleccionado:";
                    break;
                case "BtnOutRemoveNotExist":
                    translatedText = "No existe el movimiento para el período seleccionado.";
                    break;
                case "BtnOutSaveEnterAmount":
                    translatedText = "Debe ingresar un monto.";
                    break;
                case "BtnOutSaveWrongValue":
                    translatedText = "Valor de egreso incorrecto.";
                    break;
                case "ExistingOutflow":
                    translatedText = "El tipo seleccionado ya está cargado.";
                    break;
                case "BtnOutTypesRemoveClick":
                    translatedText = "Va a eliminar definitivamente el tipo de egreso seleccionado ¿Está seguro? \nEgreso seleccionado:";
                    break;
                case "OutflowAlreadyLoaded":
                    translatedText = "El egreso ingresado ya está cargado.";
                    break;
                case "CompleteFieldName":
                    translatedText = "Debe completar el campo 'Nombre'.";
                    break;
                case "LengthNameInvalid":
                    translatedText = "Solo se permiten ingresar hasta 14 carácteres para el campo nombre.";
                    break;
                case "UpdateDgv":
                    translatedText = "No hay egresos cargados en el mes seleccionado. ¿Quieres precargar los tipos de egresos que ya existen?";
                    break;              
            }
            return translatedText;
        }

        // frmOutflowsPreload Controls => We use this methods to filter control or message
        public string FrmOutflowsPreloadControlsTraduction(string Filter)
        {
            string translatedText = "";
            switch (Filter)
            {
                case "frmOutflowsPreload":
                    translatedText = "Precarga";
                    break;
                case "gbxDaily":
                    translatedText = "Egresos diarios";
                    break;
                case "gbxOthers":
                    translatedText = "Otros Egresos";
                    break;
            }
            return translatedText;
        }

        // frmOutflowsPreload Messages
        public string FrmOutflowsPreloadMessageTraduction(string Filter)
        {
            string translatedText = "";
            switch (Filter)
            {
                case "BtnSaveClick":
                    translatedText = "Cargará las salidas predeterminadas seleccionadas. ¿Está seguro?";
                    break;
            }
            return translatedText;
        }

        // frmNotes Controls => We use this methods to filter control or message
        public string FrmNotesControlsTraduction(string Filter)
        {
            string translatedText = "";
            switch (Filter)
            {
                case "frmNotes":
                    translatedText = "Notas";
                    break;
            }
            return translatedText;
        }

        // frmNotes Messages
        public string FrmNotesMessageTraduction(string Filter)
        {
            string translatedText = "";
            switch (Filter)
            {
                case "IniNotes":
                    translatedText = "El archivo 'Notes.txt' no existe en la carpeta 'GastosApp'. Reinicie la aplicación para que se pueda generar automáticamente.";
                    break;
            }
            return translatedText;
        }

        // frmAbout Controls => We use this methods to filter control or message
        public string FrmHelpControlsTraduction(string Filter)
        {
            string translatedText = "";
            switch (Filter)
            {
                case "frmHelp":
                    translatedText = "Ayuda";
                    break;
                case "btnReturn":
                    translatedText = "Volver";
                    break;
                case "OutflowsTitle":
                    translatedText = "Egresos\n\n";
                    break;
                case "OutflowsParagraph":
                    translatedText = "A través de este menú podremos cargar los egresos de cada mes, tanto los gastos diarios, como los ocasionales.\n\n";
                    break;
                case "IncomesTitle":
                    translatedText = "Ingresos\n\n";
                    break;
                case "IncomesParagraph":
                    translatedText = "En este menú podremos cargar todos los ingresos, como pueden ser sueldos, pensiones, etc.\n\n";
                    break;
                case "UserGuide":
                    translatedText = "Guía de uso (egresos e ingresos)\n\n";
                    break;
                case "UserGuideParagraphOne":
                    translatedText = "Ambos menús disponen de grillas con datos, las de la izquierda corresponden a los movimientos del mes, y la de la derecha a los 'tipos' de movimientos que iremos cargando.\n";
                    break;
                case "UserGuideParagraphTwo":
                    translatedText = "Además en la parte inferior de las grillas hay un panel de color negro con botones, a través de estos podremos eliminar o inactivar tanto movimientos, como tipos.\n\n";
                    break;
                case "NotesTitle":
                    translatedText = "Notas\n\n";
                    break;
                case "NotesParagraph":
                    translatedText = "Este menú lo podemos usar como un anotador, es muy simple de usar, y se guarda de forma automática al salir.\n\n";
                    break;
                case "AboutTitle":
                    translatedText = "Acerca de\n\n";
                    break;
                case "AboutParagraph":
                    translatedText = "Este menú contiene información de la versión actual de la aplicación, de contacto, lenguaje de programación y motor de base de datos utilizado.\n\n";
                    break;

            }
            return translatedText;
        }

        // frmAbout Controls => We use this methods to filter control or message
        public string FrmAboutControlsTraduction(string Filter)
        {
            string translatedText = "";
            switch (Filter)
            {
                case "btnReturn":
                    translatedText = "Volver";
                    break;
                case "lblDeveloped":
                    translatedText = "Desarrollado por: Daniel Flores";
                    break;
                case "lblContact":
                    translatedText = "Contacto: dan.alb.flo@gmail.com";
                    break;
                case "rtbInfo":
                    translatedText = @"Muchas gracias por usar esta aplicación.
                     Si tienes alguna pregunta, no dudes en ponerte en contacto conmigo.";
                    break;
            }
            return translatedText;
        }
    }
}
