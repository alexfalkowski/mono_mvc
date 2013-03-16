Vagrant.configure("2") do |config|
  config.vm.box = 'quantal64'
  config.vm.provision :shell, :path => 'bootstrap.sh'
  config.vm.network :forwarded_port, guest: 80, host: 9000
end