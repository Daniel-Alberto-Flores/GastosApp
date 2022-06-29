using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class TranslateToEnglish
    {
        // Method used to translate to english

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

        // frmMain Controls
        public string FrmMainControlsTraduction(string Filter)
        {
            string translatedText = "";
            switch (Filter)
            {
                case "btnOutflows":
                    translatedText = "Outflows";
                    break;
                case "btnIncomes":
                    translatedText = "Incomes";
                    break;
                case "btnNotes":
                    translatedText = "Notes";
                    break;
                case "btnHelp":
                    translatedText = "Help";
                    break;
                case "btnAbout":
                    translatedText = "About";
                    break;
                case "lblLanguage":
                    translatedText = "Language:";
                    break;
            }
            return translatedText;
        }

        // frmMain Messages
        public string FrmMainMessageTraduction(string Filter)
        {
            string translatedText = "";
            switch (Filter)
            {
                case "LanguageUpdated":
                    translatedText = "Language updated.";
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
                    translatedText = "Incomes";
                    break;
                case "btnReturn":
                    translatedText = "Return";
                    break;
                case "gbxListInc":
                    translatedText = "Incomes list";
                    break;
                case "gbxCalculatorInc":
                    translatedText = "Calculator";
                    break;
                case "lblInc":
                    translatedText = "Income:";
                    break;
                case "lblIncName":
                    translatedText = "Name";
                    break;
                case "lblIncAmount":
                    translatedText = "Amount ($):";
                    break;
                case "lblIncValue":
                    translatedText = "Value";
                    break;
                case "gbxIncTypes":
                    translatedText = "Add income types";
                    break;
                case "lblIncTypeNewName":
                    translatedText = "Name:";
                    break;
                case "lblBalance":
                    translatedText = "Balance ($):";
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
                    translatedText = "It will delete the selected income for the current period. Are you sure? \nSelected income:";
                    break;
                case "BtnIncRemoveNotExist":
                    translatedText = "The movement does not exist for the selected period.";
                    break;
                case "BtnIncSaveEnterAmount":
                    translatedText = "You must enter an amount.";
                    break;
                case "BtnIncSaveWrongValue":
                    translatedText = "Wrong income value.";
                    break;
                case "ExistingIncome":
                    translatedText = "The selected type is already loaded.";
                    break;
                case "BtnIncTypesRemoveClick":
                    translatedText = "It will definitively delete the type of income selected. Are you sure? \nSelected income:";
                    break;
                case "IncomeAlreadyLoaded":
                    translatedText = "The entered income is already loaded.";
                    break;
                case "CompleteFieldName":
                    translatedText = "You must complete the field 'Name'.";
                    break;
                case "LengthNameInvalid":
                    translatedText = "Only up to 14 characters are allowed for the name field.";
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
                    translatedText = "Outflows";
                    break;
                case "btnReturn":
                    translatedText = "Return";
                    break;
                case "gbxListOut":
                    translatedText = "Outflows list";
                    break;
                case "lblOutDaily":
                    translatedText = "Daily:";
                    break;
                case "lblOutOthers":
                    translatedText = "Others:";
                    break;
                case "gbxCalculatorOut":
                    translatedText = "Calculator";
                    break;
                case "lblOut":
                    translatedText = "Outflow:";
                    break;
                case "lblOutName":
                    translatedText = "Name";
                    break;
                case "lblOutAmount":
                    translatedText = "Amount ($):";
                    break;
                case "lblOutValue":
                    translatedText = "Value";
                    break;
                case "gbxOutTypes":
                    translatedText = "Add outflow types";
                    break;
                case "lblOutTypeNewName":
                    translatedText = "Name:";
                    break;
                case "lblOutTypeDaily":
                    translatedText = "Daily:";
                    break;
                case "lblBalance":
                    translatedText = "Balance ($):";
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
                    translatedText = "It will delete the selected outflow for the current period. Are you sure? \nSelected outflow:";
                    break;
                case "BtnOutRemoveNotExist":
                    translatedText = "The movement does not exist for the selected period.";
                    break;
                case "BtnOutSaveEnterAmount":
                    translatedText = "You must enter an amount.";
                    break;
                case "BtnOutSaveWrongValue":
                    translatedText = "Wrong outflow value.";
                    break;
                case "ExistingOutflow":
                    translatedText = "The selected type is already loaded.";
                    break;
                case "BtnOutTypesRemoveClick":
                    translatedText = "It will definitively delete the type of outflow selected. Are you sure? \nSelected outflow:";
                    break;
                case "OutflowAlreadyLoaded":
                    translatedText = "The entered outflow is already loaded.";
                    break;
                case "CompleteFieldName":
                    translatedText = "You must complete the field 'Name'.";
                    break;
                case "LengthNameInvalid":
                    translatedText = "Only up to 14 characters are allowed for the name field.";
                    break;
                case "UpdateDgv":
                    translatedText = "There are no outflows loaded in the selected month. Do you want to preload the types of outflows that already exist?";
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
                    translatedText = "Preload";
                        break;
                case "gbxDaily":
                    translatedText = "Outflows daily";
                    break;
                case "gbxOthers":
                    translatedText = "Others outflows";
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
                    translatedText = "Will load the selected default outflows. Are you sure?";
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
                    translatedText = "Notes";
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
                    translatedText = "The 'Notes.txt' file does not exist in the 'GastosApp' folder. Please restart the application so that it can be generated automatically.";
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
                    translatedText = "Help";
                    break;
                case "btnReturn":
                    translatedText = "Return";
                    break;
                case "OutflowsTitle":
                    translatedText = "Outflows\n\n";
                    break;
                case "OutflowsParagraph":
                    translatedText = "Through this menu we can load the outflows of each month, both daily and occasional outflows.\n\n";
                    break;
                case "IncomesTitle":
                    translatedText = "Incomes\n\n";
                    break;
                case "IncomesParagraph":
                    translatedText = "In this menu we can load all the income, such as salaries, pensions, etc.\n\n";
                    break;
                case "UserGuide":
                    translatedText = "User guide (outflows and incomes)\n\n";
                    break;
                case "UserGuideParagraphOne":
                    translatedText = "Both menus have grids with data, the ones on the left correspond to the movements of the month, and the one on the right corresponds to the 'types' of movements that we will be loading.\n";
                    break;
                case "UserGuideParagraphTwo":
                    translatedText = "In addition, in the lower part of the grids there is a black panel with buttons, through these we can eliminate or inactivate both movements and types.\n\n";
                    break;
                case "NotesTitle":
                    translatedText = "Notes\n\n";
                    break;
                case "NotesParagraph":
                    translatedText = "We can use this menu as a notepad, it is very simple to use, and it saves automatically when exiting.\n\n";
                    break;
                case "AboutTitle":
                    translatedText = "About\n\n";
                    break;
                case "AboutParagraph":
                    translatedText = "This menu contains information on the current version of the application, contact, programming language and database engine used.\n\n";
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
                    translatedText = "Return";
                    break;
                case "lblDeveloped":
                    translatedText = "Developed by: Daniel Flores";
                    break;
                case "lblContact":
                    translatedText = "Contact: dan.alb.flo@gmail.com";
                    break;
                case "rtbInfo":
                    translatedText = @"Thank you very much for using this application.
                    If you have any questions, do not hesitate to contact me.";
                    break;
            }
            return translatedText;
        }
    }
}
