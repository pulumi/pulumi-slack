import * as pulumi from "@pulumi/pulumi";
import { Conversation } from "@pulumi/slack";

// Create a new Slack channel
const channel = new Conversation("platychat", {
  name: "platychat",
  topic: "my topic",
  isPrivate: false,
});

// Get the id of the new channel as an output
export const channelId = channel.id;
