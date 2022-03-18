import * as pulumi from "@pulumi/pulumi";
import * as slack from "@pulumi/slack";

// Create a new Slack channel
const channel = new Conversation("test", {
  name: "test-chat",
  topic: "my topic",
  isPrivate: false,
});

// Get the id of the new channel as an output
export const channelId = channel.id;
