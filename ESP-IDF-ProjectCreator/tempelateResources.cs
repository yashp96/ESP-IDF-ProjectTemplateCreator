using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ESP_IDF_ProjectCreator
{
    public partial class Form1 : Form
    {
        string projectName = "NewProject";

        string gdbinitFile = @"\.gdbinit.ci";
        string gdbinitci = @"# Connect to a running instance of OpenOCD
target remote 127.0.0.1:3333
# Reset and halt the target
mon reset halt
# Run to a specific point in ROM code,
#  where most of initialization is complete.
thb *0x40007901
c
# Load the application into RAM
load
# Run till app_main
tb app_main
c
";


        string cmakeLists = @"\CMakeLists.txt";
        string cmakelistsTemplate = @"# The following lines of boilerplate have to be in your project's CMakeLists
# in this exact order for cmake to work correctly
cmake_minimum_required(VERSION 3.5)

include($ENV{IDF_PATH}/tools/cmake/project.cmake)
project(NewProject)";

        string makefile = @"\Makefile";
        string makefileTemplate = @"#
# This is a project Makefile. It is assumed the directory this Makefile resides in is a
# project subdirectory.
#

PROJECT_NAME := NewProject

include $(IDF_PATH)/make/project.mk

";
        string maincmakeliststemp = @"idf_component_register(SRCS " + "\"NewProject.c\""
                    + "\n                    INCLUDE_DIRS \"" + ".\")";

        string componentfile = @"\component.mk";
        string componentfiletxt = @"#
# Main Makefile. This is basically the same as a component makefile.
#";






            }
 }