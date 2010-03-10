require 'socket'                # Get sockets from stdlib
SHORT_TRANSFERS = 10

x = 
x = Thread.new {
fileFeedback   = File.open("log_feedback.txt", "a")
counterFeedback = 0

puts "Feedback gathering thread."

server = TCPServer.open(2000)   # Socket to listen on port 2000
loop {                          # Servers run forever
  Thread.start(server.accept) do |client|
	puts 'Feedback start.'
    	clientInfo = "" 
    	for entry in client.peeraddr  
        	clientInfo = clientInfo + ' ' + entry.to_s()
    	end

    	timestampOriginal = Time.now
	request = client.read
	timestampAfterRead = Time.now

	fileFeedback.puts counterFeedback.to_s() + '|' + clientInfo + '|' + request.chop() + '|' + 
	timestampOriginal.to_f().to_s() + '|' + timestampAfterRead.to_f().to_s()

	counterFeedback = counterFeedback + 1
	puts 'Feedback end.'
    client.close                # Disconnect from the client
  end
}
}

fileTests = File.open("log_tests.txt", "a")
counterTesting = 0
puts "Testing thread." 

server = TCPServer.open(3000)   # Socket to listen on port 3000
loop {                          # Servers run forever
  Thread.start(server.accept) do |client|

    clientInfo = ""
    mobileInfo = ""

    for entry in client.peeraddr
	clientInfo = clientInfo + ' ' + entry.to_s()
    end

    timestampOriginal = Array.new
    timestampAfterRead = Array.new
    timestampAfterWrite = Array.new

    puts "Testing start."

    for i in 1..SHORT_TRANSFERS do
    	timestampOriginal[i] = Time.now
	client.puts "a" * 500 + '\r\n'
	timestampAfterWrite[i] = Time.now
    	request = client.gets
    	timestampAfterRead[i] = Time.now

    end

    timestampOriginal[SHORT_TRANSFERS + 1] = Time.now
    client.puts "a" * 100000 + '\r\n'
    timestampAfterWrite[SHORT_TRANSFERS + 1] = Time.now
    request = client.gets
    timestampAfterRead[SHORT_TRANSFERS + 1] = Time.now

    mobileInfo = client.gets.chop()

    for i in 1..SHORT_TRANSFERS + 1
	fileTests.puts counterTesting.to_s() + '|' + i.to_s() + '|SERVER|' + clientInfo + '|' + mobileInfo +
	timestampOriginal[i].to_f().to_s() + ' | ' + timestampAfterWrite[i].to_f().to_s() +
        ' | ' + timestampAfterRead[i].to_f().to_s()
    end

    for i in 1..SHORT_TRANSFERS + 1
	request = client.gets
	fileTests.puts counterTesting.to_s() + '|' + i.to_s() + 
	'|CLIENT|' + clientInfo + '|' + mobileInfo + request
    end

    client.close                # Disconnect from the client
    counterTesting = counterTesting + 1
    puts 'Testing end.'
  end
}

x.join()
