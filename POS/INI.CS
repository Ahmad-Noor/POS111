using System;
using System.Collections.Generic;
using System.Linq;

namespace INI
{

    /// <summary>
    /// This exception is thrown whenever the specified section does not exist.
    /// </summary>
    public class SectionDoesNotExistException : Exception
    {

        private string _msg = string.Empty;
        private string _section = string.Empty;

        public override string Message
        {
            get { return string.Format("The section \"{0}\" does not exist!", _section); }
        }

        public SectionDoesNotExistException(string section)
        {
            _section = section;
        }

    }

    /// <summary>
    /// This exception is thrown whenever the specified field inside a section does not exist.
    /// </summary>
    public class FieldDoesNotExistException : Exception
    {

        private string _msg = string.Empty;
        private string _section = string.Empty;
        private string _field = string.Empty;

        public override string Message
        {
                get { return string.Format("The field \"{0}\" does not exist in the section \"{1}\"!", _field, _section); }
        }

        public FieldDoesNotExistException(string section, string field)
        {
            _section = section;
            _field = field;
        }

    }


    /// <summary>
    /// This structure contains the INI data read from the file.
    /// </summary>
    public struct Item
    {

        /// <summary>
        /// The field name of this item.
        /// </summary>
        public string Field { get; set; }

        /// <summary>
        /// The value of the object.
        /// 
        /// The type of value will either be:
        /// 1) String
        /// 2) Boolean
        /// 3) Decimal
        /// </summary>
        public object Value { get; set; }

    }

    /// <summary>
    /// An easy to use, managed class to create, read, write, and modify INI files.
    /// </summary>
    public class Ini
    {

        #region Properties

        /// <summary>
        /// Internal use, used for making sure sections and their respective items are kept organized.
        /// </summary>
        private Dictionary<string, List<Item>> Items { get; set; }

        /// <summary>
        /// Get the different sections in the INI file.
        /// </summary>
        public IEnumerable<string> Sections { get { return Items.Keys.ToList(); } }

        #endregion

        #region Initialization and Getter

        /// <summary>
        /// Creates a new INI class.
        /// </summary>
        public Ini()
        {
            Items = new Dictionary<string, List<Item>>();
        }

        /// <summary>
        /// A public accessor to retrieve items based on their section
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Item> this[string name]
        {
            get
            {
                if(!SectionExists(name))
                    Add(name);
                return Items[name];
            }
            set
            {
                if (!SectionExists(name))
                    Add(name);
                Items[name] = value;
            }
        }

        #endregion

        #region Add & Remove

        /// <summary>
        /// Adds a new section to the INI file.
        /// </summary>
        /// <param name="section">The name of the section to add.</param>
        public void Add(string section)
        {
            if(!SectionExists(section))
                Items.Add(section, new List<Item>());
        }

        /// <summary>
        /// Adds a new field to the INI file.
        /// </summary>
        /// <param name="section">The section to add the field under.</param>
        /// <param name="field">The name of the field.</param>
        /// <param name="value">The value to add. The value must be either a number, a boolean, or a string.</param>
        public void Add(string section, string field, object value)
        {
            if (!SectionExists(section) || (FieldExists(section, field))) return;
            this[section].Add(new Item {Field = field, Value = value});
        }


        /// <summary>
        /// Removes a section from the INI file.
        /// </summary>
        /// <param name="section">The name of the section to remove.</param>
        public void Remove(string section)
        {
            if (!SectionExists(section)) return;
            Items.Remove(section);
        }

        /// <summary>
        /// Removes a field from a specified section in the INI file.
        /// </summary>
        /// <param name="section">The name of the section to look under.</param>
        /// <param name="field">The name of the field to remove.</param>
        public void Remove(string section, string field)
        {
            if (!SectionExists(section) || !FieldExists(section, field)) return;
            var itemList = this[section];
            for (var i = 0; i < itemList.Count; i++)
            {
                if(itemList[i].Field.Equals(field))
                {
                    itemList.RemoveAt(i);
                }
            }
            this[section] = itemList;
        }

        #endregion

        #region Existance Checking

        /// <summary>
        /// Checks to see if a section exists.
        /// </summary>
        /// <param name="section">The name of the section to check.</param>
        /// <returns>Boolean</returns>
        private bool SectionExists(string section)
        {
            return Sections.Where(sectionName => sectionName.Equals(section)).Count().Equals(1);
        }

        /// <summary>
        /// Checks to see if a field inside of a section exists.
        /// </summary>
        /// <param name="section">The name of the section to check under.</param>
        /// <param name="field">The name of the field to look for.</param>
        /// <returns>Boolean</returns>
        private bool FieldExists(string section, string field)
        {
            return SectionExists(section) && this[section].Where(fieldName => fieldName.Field.Equals(field)).Count().Equals(1);
        }

        #endregion

        #region Get

        /// <summary>
        /// Returns the value of a field in the specified section.
        /// </summary>
        /// <param name="section">The specified section to look under.</param>
        /// <param name="field">The field to look for.</param>
        /// <returns>Object</returns>
        private object GetField(string section, string field)
        {

            // LINQ magic.
            if (SectionExists(section) && FieldExists(section, field))
            {

                // Grab the field and return it.
                return this[section].Where(fieldName => fieldName.Field.Equals(field)).ToList()[0].Value;

            }

            throw new SectionDoesNotExistException(section);

        }

        /// <summary>
        /// Returns the value of a field in the specified section as a boolean
        /// </summary>
        /// <param name="section">The specified section to look under.</param>
        /// <param name="field">The field to look for.</param>
        /// <returns>Boolean</returns>
        public bool GetBooleanField(string section, string field)
        {
            return Convert.ToBoolean(GetField(section, field));
        }

        /// <summary>
        /// Returns the value of a field in the specified section as a decimal.
        /// </summary>
        /// <param name="section">The specified section to look under.</param>
        /// <param name="field">The field to look for.</param>
        /// <returns>Decimal</returns>
        public decimal GetNumberField(string section, string field)
        {
            return Convert.ToDecimal(GetField(section, field));
        }

        /// <summary>
        /// Returns the value of a field in the specified section as a string.
        /// </summary>
        /// <param name="section">The specified section to look under.</param>
        /// <param name="field">The field to look for.</param>
        /// <returns>String</returns>
        public string GetStringField(string section, string field)
        {
            return GetField(section, field).ToString();
        }

        #endregion

        #region Set

        /// <summary>
        /// Sets the value of the specified field.
        /// </summary>
        /// <param name="section">The section to look under.</param>
        /// <param name="field">The field to look for.</param>
        /// <param name="value">The value to set.</param>
        private void SetField(string section, string field, object value)
        {

            // Check to see that the field and section exists
            if (!SectionExists(section)) throw new SectionDoesNotExistException(section);
            if (!FieldExists(section, field)) throw new FieldDoesNotExistException(section, field);

            // Grab the field list
            var fieldList = this[section];

            // Loop
            for (var i = 0; i < fieldList.Count; i++)
            {
                
                //Is this it? If not, continue.
                if (!fieldList[i].Field.Equals(field)) continue;

                // Grab the field
                var fieldData = fieldList[i];
                fieldData.Value = value;
                fieldList[i] = fieldData;

            }

            // Set it back
            this[section] = fieldList;

        }

        /// <summary>
        /// Sets the value of the specified field to a boolean value.
        /// </summary>
        /// <param name="section">The section to look under.</param>
        /// <param name="field">The field to look for.</param>
        /// <param name="value">The value to set.</param>
        public void SetBooleanField(string section, string field, bool value)
        {
            SetField(section, field, value);
        }

        /// <summary>
        /// Sets the value of the specified field to a numerical value.
        /// </summary>
        /// <param name="section">The section to look under.</param>
        /// <param name="field">The field to look for.</param>
        /// <param name="value">The value to set.</param>
        public void SetNumberField(string section, string field, decimal value)
        {
            SetField(section, field, value);
        }

        /// <summary>
        /// Sets the value of the specified field to a string value.
        /// </summary>
        /// <param name="section">The section to look under.</param>
        /// <param name="field">The field to look for.</param>
        /// <param name="value">The value to set.</param>
        public void SetStringField(string section, string field, string value)
        {
            SetField(section, field, value);
        }

        #endregion

        #region Save and Load

        public void Load(string iniFile)
        {

            // Read all the lines in, remove all the blank space.
            var rawFileData =
                System.IO.File.ReadAllLines(iniFile).Where(line => !line.Equals(string.Empty) && !line.StartsWith(";"));

            // Define a variable for use later.
            var currentSection = string.Empty;

            // Begin looping data!
            foreach (var line in rawFileData)
            {
                
                // Check
                if (line.StartsWith("["))
                {
                    currentSection = line.TrimStart('[').TrimEnd(']');
                    if (!SectionExists(currentSection)) Add(currentSection);
                }
                else
                {

                    // Take the item and split it.
                    var lineData = line.Split('=');
                    for (var i = 0; i < lineData.Count(); i++)
                        lineData[i] = lineData[i].Trim();

                    // Try some conversions to store the item as their natural format.
                    bool boolTest;
                    decimal numTest;

                    // Boolean test
                    if(Boolean.TryParse(lineData[1], out boolTest))
                    {
                        this[currentSection].Add(new Item { Field = lineData[0], Value = boolTest });

                        // Move along
                        continue;

                    }

                    // Number test
                    if (Decimal.TryParse(lineData[1], out numTest))
                    {

                        this[currentSection].Add(new Item { Field = lineData[0], Value = numTest });

                        // Move along
                        continue;

                    }

                    // It's a string, add it and keep going.
                    this[currentSection].Add(new Item { Field = lineData[0], Value = lineData[1] });

                }

            }
            
        }
        public void Save(string iniFile)
        {
            
            // Okay, create the file stream
            var sw = new System.IO.StreamWriter(iniFile);

            // Loop
            foreach (var section in Sections)
            {
                
                // Start off each section with [sectionName]
                sw.WriteLine(string.Format("[{0}]", section));

                // Now get items.
                var items = this[section];

                // Loop and write data out.
                foreach (var item in items)
                    sw.WriteLine("{0}={1}", item.Field, item.Value);

                // Blank gap
                sw.WriteLine();

            }

            // All done
            sw.Close();

        }

        #endregion

    }

}