require 'albacore'

CURRENT_PATH = File.expand_path(File.dirname(__FILE__))
VERSION = '1.0.0'
ARTIFACTS_PATH = File.join(CURRENT_PATH, 'artifacts')

desc 'Get all the referenced packages'
exec :packages do |command|
  FileUtils.rm_rf('packages')
  command.command = 'tools/nuget'
  command.parameters 'install packages.config -o packages'
end

desc 'Build the solution'
xbuild :build do |build|
  FileUtils.rm_rf(ARTIFACTS_PATH)
  build.solution = 'Mvc.sln'
  build.properties = { :configuration => :Release, :OutputPath => ARTIFACTS_PATH }
  build.targets :Rebuild
  build.verbosity = 'quiet'
  build.parameters '/nologo'
end

desc 'Run the specs'
nunit :specs => :build do |nunit|
  file = 'tools/nunit-console'
  nunit.command = file
  nunit.options '-noshadow'
  nunit.assemblies 'artifacts/System.Spec.Specs.dll'
  nunit.parameters '-nologo'
end
