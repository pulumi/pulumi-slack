import * as pulumi from "@pulumi/pulumi";
import { SlackConversation } from "@pulumi/slack"

// Create a new Slack channel
const channel = new SlackConversation("platychat", {
    name: "platychat",
    topic: "my topic",
    isPrivate: false,
})

// Get the id of the new channel as an output
export const channelId = channel.id
