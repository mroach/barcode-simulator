require 'rubygems'
require 'albacore'
require 'version_bumper'

APPLICATION_NAME = 'BarcodeSimulator'
APPLICATION_TITLE = 'Barcode Simulator'
SOLUTION_FILE = 'BarcodeSimulator.sln'
PROJECT_DIR = 'BarcodeSimulator'
COMPANY = 'Michael Roach'
COPYRIGHT = 'None'
BUILD_CONFIGURATION = "Release"
BUILD_PROPERTIES = {
	:configuration => BUILD_CONFIGURATION,
	:nowarn => "1573;1572;1591;1574", # suppresses XML comment warnings which we don't care about
}

def buildnumber
	bumper_version.to_s
end

task :default => ["bump:build", :build]

assemblyinfo :assemblyinfo  do |asm|
  asm.version = buildnumber
  asm.company_name = COMPANY
  asm.product_name = APPLICATION_NAME
  asm.copyright = COPYRIGHT
  asm.title = APPLICATION_TITLE
  asm.description = APPLICATION_TITLE
  asm.output_file = "#{PROJECT_DIR}/Properties/AssemblyInfo.cs"
end

msbuild :build => [:assemblyinfo] do |msb|
  msb.targets :clean, :build
  msb.solution = SOLUTION_FILE
  msb.properties = BUILD_PROPERTIES
  msb.verbosity = "minimal"
end

task :package => ["bump:revision", :build] do
  Dir.mkdir('releases') unless Dir.exists?('releases')
  FileUtils.cp("#{PROJECT_DIR}/bin/#{BUILD_CONFIGURATION}/#{APPLICATION_NAME}.exe", "releases/#{APPLICATION_NAME}-v#{buildnumber}.exe")
end